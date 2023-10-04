using HypeHubLogic.DTOs.Item;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Item.Commands.Post;

public class CreateItemCommand : IRequest<ItemGenerallReadDTO>
{
    public ItemCreateDTO Item { get; init; }
    public IEnumerable<Claim> Claims { get; init; }

    public CreateItemCommand(ItemCreateDTO item, IEnumerable<Claim> claims)
    {
        Item = item;
        Claims = claims;
    }
}
