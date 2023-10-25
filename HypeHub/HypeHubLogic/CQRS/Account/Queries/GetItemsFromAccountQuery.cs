using HypeHubLogic.DTOs.Item;
using MediatR;

namespace HypeHubLogic.CQRS.Account.Queries;
public class GetItemsFromAccountQuery : IRequest<List<ItemWithImagesAndLikesReadDTO>>
{
    public Guid AccountId { get; set; }
    public GetItemsFromAccountQuery(Guid accountId)
    {
        AccountId = accountId;
    }
}
