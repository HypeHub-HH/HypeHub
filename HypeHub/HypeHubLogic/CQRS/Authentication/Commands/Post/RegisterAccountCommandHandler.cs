using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Registration;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HypeHubLogic.CQRS.Authentication.Commands.Post;

public class RegisterAccountCommandHandler : IRequestHandler<RegisterAccountCommand, RegistrationReadDTO>
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IMapper _mapper;
    private readonly IValidator<RegistrationCreateDTO> _validator;
    private readonly IAccountRepository _accountRepository;

    public RegisterAccountCommandHandler(UserManager<IdentityUser> userManager, IMapper mapper, IValidator<RegistrationCreateDTO> validator, IAccountRepository accountRepository)
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
        var user = new IdentityUser { UserName = userName, Email = email };
        var result = await _userManager.CreateAsync(user, password);
        if (!result.Succeeded) throw new InternalIdentityServerException("Server failed", result.Errors.Select(error => error.Description));

        var account = new Account(userName, false, HypeHubDAL.Models.Types.AccountTypes.User, null);
        var createdAccount = _accountRepository.AddAsync(account);

        return _mapper.Map<RegistrationReadDTO>(request.RegistrationCreateDTO);
    }

}
