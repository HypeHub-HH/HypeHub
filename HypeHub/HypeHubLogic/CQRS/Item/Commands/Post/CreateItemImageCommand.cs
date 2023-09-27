using HypeHubLogic.DTOs.ItemImage;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Post;

public class CreateItemImageCommand : IRequest<ItemImageReadDTO>
{
    public ItemImageCreateDTO ItemImage { get; set; }
    public CreateItemImageCommand(ItemImageCreateDTO itemImage)
    {
        ItemImage = itemImage;
    }
}
