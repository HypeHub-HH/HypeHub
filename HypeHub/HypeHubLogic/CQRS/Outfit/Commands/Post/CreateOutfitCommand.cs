using HypeHubLogic.DTOs.Outfit;
using MediatR;
using System.Security.Claims;
namespace HypeHubLogic.CQRS.Outfit.Commands.Post;
public class CreateOutfitCommand : IRequest<OutfitGenerallReadDTO>
{
    public OutfitCreateDTO Outfit { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public CreateOutfitCommand(OutfitCreateDTO outfit, IEnumerable<Claim> claims)
    {
        Outfit = outfit;
        Claims = claims;
    }
}
