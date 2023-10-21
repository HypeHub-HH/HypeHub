using HypeHubLogic.DTOs.ItemImage;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Queries;
public class GetItemImageQuery : IRequest<ItemImageReadDTO>
{
    public Guid ItemImageId { get; init; }
    public GetItemImageQuery(Guid itemImageId)
    {
        ItemImageId = itemImageId;
    }
}
