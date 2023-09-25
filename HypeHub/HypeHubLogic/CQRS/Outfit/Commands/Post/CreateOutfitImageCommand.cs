using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;

public class CreateOutfitImageCommand : IRequest<OutfitImageReadDTO>
{
    public Guid OutfitId { get; init; }
    public OutfitImageCreateDTO OutfitImage { get; init; }

    public CreateOutfitImageCommand(Guid outfitId, OutfitImageCreateDTO outfitImage)
    {
        OutfitId = outfitId;
        OutfitImage = outfitImage;
    }
}
