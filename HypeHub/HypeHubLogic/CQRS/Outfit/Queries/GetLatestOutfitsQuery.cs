using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;

public class GetLatestOutfitsQuery : IRequest<OutfitImageReadDTO>
{
    public int Page { get; init; }
    public int Count { get; init; }

    public GetLatestOutfitsQuery(int page, int count)
    {
        Page = page;
        Count = count;
    }
}