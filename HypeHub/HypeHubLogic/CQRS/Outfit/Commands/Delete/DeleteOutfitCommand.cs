using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Outfit.Commands.Delete;

public class DeleteOutfitCommand : IRequest
{
    public Guid OutfitId { get; init; }
    public IEnumerable<Claim> Claims { get; init; }

    public DeleteOutfitCommand(Guid outfitId, IEnumerable<Claim> claims)
    {
        OutfitId = outfitId;
        Claims = claims;
    }
}