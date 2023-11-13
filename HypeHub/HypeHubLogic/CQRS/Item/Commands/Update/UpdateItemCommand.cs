using HypeHubLogic.DTOs.Item;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Item.Commands.Update;
public class UpdateItemCommand : IRequest<ItemGenerallReadDTO>
{
    public Guid Id { get; init; }
    public ItemUpdateDTO Item { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public UpdateItemCommand(Guid id, ItemUpdateDTO item, IEnumerable<Claim> claims)
    {
        Id = id;
        Item = item;
        Claims = claims;
    }
}
