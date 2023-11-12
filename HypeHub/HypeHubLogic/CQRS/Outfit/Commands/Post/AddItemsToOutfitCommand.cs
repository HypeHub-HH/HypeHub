using HypeHubDAL.Models.Relations;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;
public class AddItemsToOutfitCommand : IRequest<List<OutfitItem>>
{
    public List<Guid> Items { get; init; }
    public Guid OutfitId { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public AddItemsToOutfitCommand(List<Guid> items, Guid outfitId, IEnumerable<Claim> claims)
    {
        Items = items;
        OutfitId = outfitId;
        Claims = claims;
    }
}