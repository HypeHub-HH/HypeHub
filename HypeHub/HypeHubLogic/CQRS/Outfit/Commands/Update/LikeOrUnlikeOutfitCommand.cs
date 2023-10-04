using HypeHubLogic.DTOs.AccountOutfitLike;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Outfit.Commands.Update;

public class LikeOrUnlikeOutfitCommand : IRequest
{
    public Guid OutfitId { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public LikeOrUnlikeOutfitCommand(Guid outfitId, IEnumerable<Claim> claims)
    {
        OutfitId = outfitId;
        Claims = claims;
    }
}
