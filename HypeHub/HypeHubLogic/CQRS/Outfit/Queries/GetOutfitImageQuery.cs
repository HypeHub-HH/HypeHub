using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;

public class GetOutfitImageQuery : IRequest<OutfitImageReadDTO>
{
    public Guid OutfitId { get; init; }
    public Guid OutfitImageId { get; init; }

    public GetOutfitImageQuery(Guid outfitId, Guid outfitImageId)
    {
        OutfitId = outfitId;
        OutfitImageId = outfitImageId;
    }
}