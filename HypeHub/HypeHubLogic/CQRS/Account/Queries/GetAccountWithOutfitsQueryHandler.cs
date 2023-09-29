using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;
using MediatR;

namespace HypeHubLogic.CQRS.Account.Queries;

public class GetAccountWithOutfitsQueryHandler : IRequestHandler<GetAccountWithOutfitsQuery, AccountWithOutfitsReadDTO>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;

    public GetAccountWithOutfitsQueryHandler(IAccountRepository accountRepository, IMapper mapper)
    {
        _accountRepository = accountRepository;
        _mapper = mapper;
    }

    public async Task<AccountWithOutfitsReadDTO> Handle(GetAccountWithOutfitsQuery request, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetAccountWithOutfitsAsync(request.AccountId) ?? throw new NotFoundException($"There is no account with the given Id: {request.AccountId}.");
        var mappedAccount = _mapper.Map<AccountWithOutfitsReadDTO>(account);
        return mappedAccount;
    }
}
