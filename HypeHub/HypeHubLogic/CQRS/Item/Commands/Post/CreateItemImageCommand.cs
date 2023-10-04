using HypeHubLogic.DTOs.ItemImage;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Item.Commands.Post;

public class CreateItemImageCommand : IRequest<ItemImageReadDTO>
{
    public ItemImageCreateDTO ItemImage { get; set; }
    public IEnumerable<Claim> Claims { get; init; }
    public CreateItemImageCommand(ItemImageCreateDTO itemImage, IEnumerable<Claim> claims)
    {
        ItemImage = itemImage;
        Claims = claims;
    }
}
