using HypeHubLogic.DTOs.Outfit;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;
public class GetOutfitWithAccountAndLikesAndImagesAndItemsQuery : IRequest<OutfitWithAccountAndImagesAndLikesAndItemsReadDTO>
{
    public Guid OutfitId { get; init; }
    public GetOutfitWithAccountAndLikesAndImagesAndItemsQuery(Guid outfitId)
    {
        OutfitId = outfitId;
    }
}