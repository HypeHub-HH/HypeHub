using HypeHubLogic.DTOs.Outfit;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;

public class GetOutfitQuery : IRequest<OutfitGenerallReadDTO>
{
    public Guid OutfitId { get; init; }

    public GetOutfitQuery(Guid outfitId)
    {
        OutfitId = outfitId;
    }
}