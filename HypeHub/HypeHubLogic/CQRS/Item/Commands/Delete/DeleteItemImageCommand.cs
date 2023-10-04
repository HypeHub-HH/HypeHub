using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Item.Commands.Delete;

public class DeleteItemImageCommand : IRequest
{
    public Guid ItemImageId { get; init; }
    public IEnumerable<Claim> Claims { get; init; }

    public DeleteItemImageCommand(Guid itemImageId, IEnumerable<Claim> claims)
    {
        ItemImageId = itemImageId;
        Claims = claims;
    }
}
