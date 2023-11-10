using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Account.Commands.Update;
public class UpdateAccountAvatarCommandHandler : IRequestHandler<UpdateAccountAvatarCommand, AccountGeneralInfoReadDTO>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IValidator<AccountUpdateAvatarDTO> _validator;
    private readonly IMapper _mapper;

    public UpdateAccountAvatarCommandHandler(IAccountRepository accountRepository, IValidator<AccountUpdateAvatarDTO> validator, IMapper mapper)
    {
        _accountRepository = accountRepository;
        _validator = validator;
        _mapper = mapper;
    }

    public async Task<AccountGeneralInfoReadDTO> Handle(UpdateAccountAvatarCommand request, CancellationToken cancellationToken)
    {
        var userId = Guid.Parse(request.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value);
        var validationResult = await _validator.ValidateAsync(request.Account);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult.Errors.Select(error => error.ErrorMessage));
        var accountForUpdate = await _accountRepository.GetByIdAsync(userId) ?? throw new NotFoundException($"No account to update found"); 
        accountForUpdate.AvatarUrl = request.Account.AvatarUrl;
        var updatedAccount = await _accountRepository.UpdateAsync(accountForUpdate);
        return _mapper.Map<AccountGeneralInfoReadDTO>(updatedAccount);
    }
}
