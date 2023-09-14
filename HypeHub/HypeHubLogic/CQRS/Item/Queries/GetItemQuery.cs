using HypeHubLogic.DTOs.Item;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Queries;

public class GetItemQuery : IRequest<ItemReadDTO>
{
    public Guid ItemId { get; set; }
    public GetItemQuery(Guid itemId)
    {
        ItemId = itemId;
    }
}
