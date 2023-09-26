using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;

public class CreateOutfitImageCommand : IRequest<OutfitImageReadDTO>
{
    public OutfitImageCreateDTO OutfitImage { get; init; }

    public CreateOutfitImageCommand(OutfitImageCreateDTO outfitImage)
    {
        OutfitImage = outfitImage;
    }
}
