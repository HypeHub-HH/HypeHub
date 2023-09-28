using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;
using MediatR;
using Microsoft.Identity.Client;

namespace HypeHubLogic.CQRS.Account.Queries;

public class GetAccountQueryHandler : IRequestHandler<GetAccountQuery, AccountReadDTO>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;

    public GetAccountQueryHandler(IAccountRepository accountRepository, IMapper mapper)
    {
        _accountRepository = accountRepository;
        _mapper = mapper;
    }

    public async Task<AccountReadDTO> Handle(GetAccountQuery request, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetAccountWithOutfits(request.AccountId) ?? throw new NotFoundException($"There is no account with the given ID: {request.AccountId}.");
        var mappedAccount = _mapper.Map<AccountReadDTO>(account);
        return mappedAccount;
    }
}
