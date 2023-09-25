using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Delete;

public class DeleteOutfitImageCommand : IRequest
{
    public Guid OutfitId { get; init; }
    public Guid OutfitImageId { get; init; }

    public DeleteOutfitImageCommand(Guid outfitId, Guid outfitImageId)
    {
        OutfitId = outfitId;
        OutfitImageId = outfitImageId;
    }
}