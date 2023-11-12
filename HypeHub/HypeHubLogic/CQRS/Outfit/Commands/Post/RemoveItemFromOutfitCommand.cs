using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;
public class RemoveItemFromOutfitCommand : IRequest
{
    public Guid OutfitId { get; init; }
    public Guid ItemId { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public RemoveItemFromOutfitCommand(Guid outfitId, Guid itemId, IEnumerable<Claim> claims)
    {
        OutfitId = outfitId;
        ItemId = itemId;
        Claims = claims;
    }
}