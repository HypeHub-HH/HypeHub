using HypeHubLogic.DTOs.ItemImage;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Queries;

public class GetItemImagesQuery : IRequest<List<ItemImageReadDTO>>
{
    public Guid ItemId { get; init; }

    public GetItemImagesQuery(Guid itemId)
    {
        ItemId = itemId;
    }
}
