using HypeHubLogic.DTOs.Account;
using MediatR;

namespace HypeHubLogic.CQRS.Account.Queries;

public class GetAccountQuery : IRequest<AccountReadDTO>
{
    public Guid AccountId { get; set; }
    public GetAccountQuery(Guid accountId)
    {
        AccountId = accountId;
    }
}
