using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Outfit;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HypeHubLogic.CQRS.Outfit.Queries;
public class GetLatestOutfitsQueryHandler : IRequestHandler<GetLatestOutfitsQuery, PagedList<OutfitWithAccountAndImagesAndLikesReadDTO>>
{
    private readonly IOutfitRepository _outfitRepository;
    private readonly IMapper _mapper;
    public GetLatestOutfitsQueryHandler(IOutfitRepository outfitRepository, IMapper mapper)
    {
        _outfitRepository = outfitRepository;
        _mapper = mapper;
    }
    public async Task<PagedList<OutfitWithAccountAndImagesAndLikesReadDTO>> Handle(GetLatestOutfitsQuery request, CancellationToken cancellationToken)
    {
        if (request.Page <= 0 || request.PageSize <= 0) throw new BadRequestException("Page and PageSize parameters must be greater than zero.");
        var outfits = await _outfitRepository.GetLatesOutfitsWithAccountsAndImagesAndLikesAsync(request.Page, request.PageSize);
        return new PagedList<OutfitWithAccountAndImagesAndLikesReadDTO>(
            outfits.Entities.Select(outfit => _mapper.Map<OutfitWithAccountAndImagesAndLikesReadDTO>(outfit)).ToList(),
            outfits.TotalCount,
            outfits.CurrentPage,
            outfits.PageSize);
    }
}
