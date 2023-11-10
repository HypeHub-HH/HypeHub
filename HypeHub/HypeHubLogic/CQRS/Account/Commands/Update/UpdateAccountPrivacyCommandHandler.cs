using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Account.Commands.Update;
public class UpdateAccountPrivacyCommandHandler : IRequestHandler<UpdateAccountPrivacyCommand, AccountGeneralInfoReadDTO>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;

    public UpdateAccountPrivacyCommandHandler(IAccountRepository accountRepository, IValidator<AccountUpdateAvatarDTO> validator, IMapper mapper)
    {
        _accountRepository = accountRepository;
        _mapper = mapper;
    }

    public async Task<AccountGeneralInfoReadDTO> Handle(UpdateAccountPrivacyCommand request, CancellationToken cancellationToken)
    {
        var userId = Guid.Parse(request.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value);
        var accountForUpdate = await _accountRepository.GetByIdAsync(userId) ?? throw new NotFoundException($"No account to update found");
        accountForUpdate.IsPrivate = request.Account.IsPrivate;
        var updatedAccount = await _accountRepository.UpdateAsync(accountForUpdate);
        return _mapper.Map<AccountGeneralInfoReadDTO>(updatedAccount);
    }
}
