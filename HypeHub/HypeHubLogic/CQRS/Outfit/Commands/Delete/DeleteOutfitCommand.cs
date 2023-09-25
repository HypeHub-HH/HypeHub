using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Delete;

public class DeleteOutfitCommand : IRequest
{
    public Guid OutfitId { get; init; }

    public DeleteOutfitCommand(Guid outfitId)
    {
        OutfitId = outfitId;
    }
}