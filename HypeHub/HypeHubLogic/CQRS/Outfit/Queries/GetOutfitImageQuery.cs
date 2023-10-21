using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;
public class GetOutfitImageQuery : IRequest<OutfitImageReadDTO>
{
    public Guid OutfitImageId { get; init; }
    public GetOutfitImageQuery(Guid outfitImageId)
    {
        OutfitImageId = outfitImageId;
    }
}