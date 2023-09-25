using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;

public class GetOutfitImagesQuery : IRequest<List<OutfitImageReadDTO>>
{
    public Guid OutfitId { get; init; }

    public GetOutfitImagesQuery(Guid outfitId)
    {
        OutfitId = outfitId;
    }
}