using HypeHubDAL.Models.Relations;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;
public class AddItemToOutfitCommand : IRequest<OutfitItem>
{
    public Guid OutfitId { get; init; }
    public Guid ItemId { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public AddItemToOutfitCommand(Guid outfitId, Guid itemId, IEnumerable<Claim> claims)
    {
        OutfitId = outfitId;
        ItemId = itemId;
        Claims = claims;
    }
}