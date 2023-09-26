using HypeHubLogic.DTOs.ItemImage;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Post;

public class AddPhotoToItemCommand : IRequest
{
    public ItemImageCreateDTO ItemImage { get; set; }
    public AddPhotoToItemCommand(ItemImageCreateDTO itemImage)
    {
        ItemImage = itemImage;
    }
}
