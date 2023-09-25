using AutoMapper;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;

public class GetOutfitImagesQueryHandler : IRequestHandler<GetOutfitImagesQuery, List<OutfitImageReadDTO>>
{
    private readonly IOutfitRepository _outfitRepository;
    private readonly IMapper _mapper;

    public GetOutfitImagesQueryHandler(IOutfitRepository outfitRepository, IMapper mapper)
    {
        _outfitRepository = outfitRepository;
        _mapper = mapper;
    }

    public async Task<List<OutfitImageReadDTO>> Handle(GetOutfitImagesQuery request, CancellationToken cancellationToken)
    {
        var outfitImages = await _outfitRepository.GetAllOutfitImagesAsync(request.OutfitId);
        return _mapper.Map<List<OutfitImageReadDTO>>(outfitImages);
    }
}