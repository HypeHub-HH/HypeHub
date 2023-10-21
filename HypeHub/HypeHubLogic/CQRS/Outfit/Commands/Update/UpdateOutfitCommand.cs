using HypeHubLogic.DTOs.Outfit;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Outfit.Commands.Update;
public class UpdateOutfitCommand : IRequest<OutfitGenerallReadDTO>
{
    public OutfitUpdateDTO Outfit { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public UpdateOutfitCommand(OutfitUpdateDTO outfit, IEnumerable<Claim> claims)
    {
        Outfit = outfit;
        Claims = claims;
    }
}