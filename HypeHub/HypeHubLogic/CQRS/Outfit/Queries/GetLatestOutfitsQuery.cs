using HypeHubDAL.Models;
using HypeHubLogic.DTOs.Outfit;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;
public class GetLatestOutfitsQuery : IRequest<PagedList<OutfitWithAccountAndImagesAndLikesReadDTO>>
{
    public int Page { get; init; }
    public int PageSize { get; init; }
    public GetLatestOutfitsQuery(int page, int pageSize)
    {
        Page = page;
        PageSize = pageSize;
    }
}