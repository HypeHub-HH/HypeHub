using HypeHubLogic.DTOs.OutfitImage;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;
public class CreateOutfitImageCommand : IRequest<OutfitImageReadDTO>
{
    public OutfitImageCreateDTO OutfitImage { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public CreateOutfitImageCommand(OutfitImageCreateDTO outfitImage, IEnumerable<Claim> claims)
    {
        OutfitImage = outfitImage;
        Claims = claims;
    }
}
