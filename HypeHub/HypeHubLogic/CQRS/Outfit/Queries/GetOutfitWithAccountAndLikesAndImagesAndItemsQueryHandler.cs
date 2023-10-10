using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Outfit;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;

public class GetOutfitWithAccountAndLikesAndImagesAndItemsQueryHandler : IRequestHandler<GetOutfitWithAccountAndLikesAndImagesAndItemsQuery, OutfitWithAccountAndImagesAndLikesAndItemsReadDTO>
{
    private readonly IOutfitRepository _outfitRepository;
    private readonly IMapper _mapper;

    public GetOutfitWithAccountAndLikesAndImagesAndItemsQueryHandler(IOutfitRepository outfitRepository, IMapper mapper)
    {
        _outfitRepository = outfitRepository;
        _mapper = mapper;
    }

    public async Task<OutfitWithAccountAndImagesAndLikesAndItemsReadDTO> Handle(GetOutfitWithAccountAndLikesAndImagesAndItemsQuery request, CancellationToken cancellationToken)
    {
        var outfit = await _outfitRepository.GetOutfitWithAccountAndItemsAndLikesAsync(request.OutfitId) ?? throw new NotFoundException($"There is no outfit with the given Id: {request.OutfitId}.");
        return _mapper.Map<OutfitWithAccountAndImagesAndLikesAndItemsReadDTO>(outfit);
    }
}