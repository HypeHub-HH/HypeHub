using HypeHubDAL.Repositories.Interfaces;
using MediatR;

namespace HypeHubLogic.CQRS.Account.Queries;

public class CheckIfUsernameAlreadyExistQueryHandler : IRequestHandler<CheckIfUsernameAlreadyExistQuery, bool>
{
    private readonly IAccountRepository _accountRepository;

    public CheckIfUsernameAlreadyExistQueryHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<bool> Handle(CheckIfUsernameAlreadyExistQuery request, CancellationToken cancellationToken)
    {
        return await _accountRepository.CheckIfUsernameAlreadyExistAsync(request.Username);
    }
}