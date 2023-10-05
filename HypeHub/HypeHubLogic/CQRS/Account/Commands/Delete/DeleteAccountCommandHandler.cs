using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HypeHubLogic.CQRS.Account.Commands.Delete;

public class DeleteAccountCommandHandler : IRequestHandler<DeleteAccountCommand>
{
    private readonly IAccountRepository _accountRepository;
    private readonly UserManager<ApplicationUser> _userManager;

    public DeleteAccountCommandHandler(IAccountRepository accountRepository, UserManager<ApplicationUser> userManager)
    {
        _accountRepository = accountRepository;
        _userManager = userManager;
    }

    public async Task Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetByIdAsync(request.AccountId) ?? throw new NotFoundException($"There is no account with the given Id: {request.AccountId}.");
        var accountFromIdentity = await _userManager.FindByIdAsync(request.AccountId.ToString()) ?? throw new NotFoundException($"There is no credentials with the given Id: {request.AccountId}");
        await _accountRepository.DeleteAsync(account);
        await _userManager.DeleteAsync(accountFromIdentity);
    }
}
