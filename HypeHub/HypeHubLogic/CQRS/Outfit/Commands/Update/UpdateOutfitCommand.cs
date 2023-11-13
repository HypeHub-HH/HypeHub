using HypeHubLogic.DTOs.Outfit;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Outfit.Commands.Update;
public class UpdateOutfitCommand : IRequest<OutfitGenerallReadDTO>
{
    public Guid Id { get; init; }
    public OutfitUpdateDTO Outfit { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public UpdateOutfitCommand(Guid id, OutfitUpdateDTO outfit, IEnumerable<Claim> claims)
    {
        Id = id;
        Outfit = outfit;
        Claims = claims;
    }
}