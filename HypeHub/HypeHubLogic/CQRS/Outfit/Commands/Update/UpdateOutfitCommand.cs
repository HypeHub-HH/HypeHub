using HypeHubLogic.DTOs.Outfit;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Update;

public class UpdateOutfitCommand : IRequest<OutfitGenerallReadDTO>
{
    public OutfitUpdateDTO Outfit { get; init; }

    public UpdateOutfitCommand(OutfitUpdateDTO outfit)
    {
        Outfit = outfit;
    }
}