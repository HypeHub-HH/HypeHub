using HypeHubLogic.DTOs.Account;
using MediatR;

namespace HypeHubLogic.CQRS.Account.Queries;
public class GetAccountWithOutfitsQuery : IRequest<AccountWithOutfitsReadDTO>
{
    public Guid AccountId { get; set; }
    public GetAccountWithOutfitsQuery(Guid accountId)
    {
        AccountId = accountId;
    }
}
