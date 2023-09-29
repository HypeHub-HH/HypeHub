using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HypeHubLogic.CQRS.Account.Commands.Delete;

public class DeleteAccountCommandHandler : IRequestHandler<DeleteAccountCommand>
{
    private readonly IAccountRepository _accountRepository;
    private readonly UserManager<IdentityUser> _userManager;

    public DeleteAccountCommandHandler(IAccountRepository accountRepository, UserManager<IdentityUser> userManager)
    {
        _accountRepository = accountRepository;
        _userManager = userManager;
    }

    public async Task Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
    {
        //TBD
        var account = await _accountRepository.GetByIdAsync(request.AccountId) ?? throw new NotFoundException($"There is no account with the given ID: {request.AccountId}.");
        var accountFromIdentity = await _userManager.FindByEmailAsync(account.Credentials.Email) ?? throw new NotFoundException($"There is no account with the email: {account.Credentials.Email} for given ID");
        await _accountRepository.DeleteAsync(account);
        await _userManager.DeleteAsync(accountFromIdentity);
    }
}
