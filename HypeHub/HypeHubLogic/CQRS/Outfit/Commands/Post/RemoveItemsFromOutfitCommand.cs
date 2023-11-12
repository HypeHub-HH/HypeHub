using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;

public class RemoveItemsFromOutfitCommand : IRequest
{
    public List<Guid> Items { get; init; }
    public Guid OutfitId { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public RemoveItemsFromOutfitCommand(List<Guid> items, Guid outfitId, IEnumerable<Claim> claims)
    {
        Items = items;
        OutfitId = outfitId;
        Claims = claims;
    }
}