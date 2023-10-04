using AutoMapper;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;
using MediatR;

namespace HypeHubLogic.CQRS.Account.Queries;

public class GetSearchedAccountsQueryHandler : IRequestHandler<GetSearchedAccountsQuery, List<AccountGeneralInfoReadDTO>>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;

    public GetSearchedAccountsQueryHandler(IAccountRepository accountRepository, IMapper mapper)
    {
        _accountRepository = accountRepository;
        _mapper = mapper;
    }

    public async Task<List<AccountGeneralInfoReadDTO>> Handle(GetSearchedAccountsQuery request, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetSearchedAccountsAsync(request.SearchedString);
        var mappedAccounts = _mapper.Map<List<AccountGeneralInfoReadDTO>>(account);
        return mappedAccounts;
    }
}
