using AutoMapper;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;

public class GetOutfitImagesQueryHandler : IRequestHandler<GetOutfitImagesQuery, List<OutfitImageReadDTO>>
{
    private readonly IOutfitImageRepository _outfitImageRepository;
    private readonly IMapper _mapper;

    public GetOutfitImagesQueryHandler(IOutfitImageRepository outfitImageRepository, IMapper mapper)
    {
        _outfitImageRepository = outfitImageRepository;
        _mapper = mapper;
    }

    public async Task<List<OutfitImageReadDTO>> Handle(GetOutfitImagesQuery request, CancellationToken cancellationToken)
    {
        var outfitImages = await _outfitImageRepository.GetAllOutfitImagesAsync(request.OutfitId);
        return _mapper.Map<List<OutfitImageReadDTO>>(outfitImages);
    }
}