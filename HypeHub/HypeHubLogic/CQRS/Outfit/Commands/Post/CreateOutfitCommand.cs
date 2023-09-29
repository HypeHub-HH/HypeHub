using HypeHubLogic.DTOs.Outfit;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;

public class CreateOutfitCommand : IRequest<OutfitGenerallReadDTO>
{
    public OutfitCreateDTO Outfit { get; init; }

    public CreateOutfitCommand(OutfitCreateDTO outfit)
    {
        Outfit = outfit;
    }
}
