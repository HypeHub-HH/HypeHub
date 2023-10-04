using HypeHubLogic.DTOs.Item;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Item.Commands.Update;

public class UpdateItemCommand : IRequest<ItemGenerallReadDTO>
{
    public ItemUpdateDTO Item { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public UpdateItemCommand(ItemUpdateDTO item, IEnumerable<Claim> claims)
    {
        Item = item;
        Claims = claims;
    }
}
