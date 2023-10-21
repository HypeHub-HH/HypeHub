using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Outfit.Commands.Delete;
public class DeleteOutfitImageCommand : IRequest
{
    public Guid OutfitImageId { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public DeleteOutfitImageCommand(Guid outfitImageId, IEnumerable<Claim> claims)
    {
        OutfitImageId = outfitImageId;
        Claims = claims;
    }
}