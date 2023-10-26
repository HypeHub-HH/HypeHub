using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Registration;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace HypeHubLogic.CQRS.Authentication.Commands.Post;
public class RegisterAccountCommandHandler : IRequestHandler<RegisterAccountCommand, RegistrationReadDTO>
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IMapper _mapper;
    private readonly IValidator<RegistrationCreateDTO> _validator;
    private readonly IAccountRepository _accountRepository;
    public RegisterAccountCommandHandler(UserManager<ApplicationUser> userManager, IMapper mapper, IValidator<RegistrationCreateDTO> validator, IAccountRepository accountRepository)
    {
        _userManager = userManager;
        _mapper = mapper;
        _validator = validator;
        _accountRepository = accountRepository;
    }
    public async Task<RegistrationReadDTO> Handle(RegisterAccountCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request.RegistrationCreateDTO);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult.Errors.Select(error => error.ErrorMessage));

        var userName = request.RegistrationCreateDTO.Username;
        var email = request.RegistrationCreateDTO.Email;
        var password = request.RegistrationCreateDTO.Password;
        var userId = Guid.NewGuid();
        var user = new ApplicationUser { UserName = userName, Email = email, EmailConfirmed = false, Id= userId.ToString() };
        var result = await _userManager.CreateAsync(user, password);
        if (!result.Succeeded) throw new InternalIdentityServerException("Server failed", result.Errors.Select(error => error.Description));

        var addRoleResult = await _userManager.AddToRoleAsync(user, "User");
        if (!addRoleResult.Succeeded) throw new InternalIdentityServerException("Server failed", result.Errors.Select(error => error.Description));
        var account = new HypeHubDAL.Models.Account(userId, userName, false, null);
        var createdAccount = await _accountRepository.AddAsync(account);
        if (createdAccount==null) throw new InternalIdentityServerException("Server failed", new List<string>() { "Account has not been created" });
        return _mapper.Map<RegistrationReadDTO>(request.RegistrationCreateDTO);
    }
}
