using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Delete;

public class DeleteOutfitImageCommand : IRequest
{
    public Guid OutfitImageId { get; init; }

    public DeleteOutfitImageCommand(Guid outfitImageId)
    {
        OutfitImageId = outfitImageId;
    }
}