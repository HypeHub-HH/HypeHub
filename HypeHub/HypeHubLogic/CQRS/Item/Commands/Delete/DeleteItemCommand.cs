using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Item.Commands.Delete;
public class DeleteItemCommand : IRequest
{
    public Guid ItemId { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public DeleteItemCommand(Guid itemId, IEnumerable<Claim> claims)
    {
        ItemId = itemId;
        Claims = claims;
    }
}
