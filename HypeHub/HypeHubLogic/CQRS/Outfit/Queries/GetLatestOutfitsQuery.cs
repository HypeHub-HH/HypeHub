using HypeHubLogic.DTOs.Outfit;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;
public class GetLatestOutfitsQuery : IRequest<List<OutfitWithAccountAndImagesAndLikesReadDTO>>
{
    public int Page { get; init; }
    public int Count { get; init; }
    public GetLatestOutfitsQuery(int page, int count)
    {
        Page = page;
        Count = count;
    }
}