using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;

public class GetOutfitImagesQueryHandler : IRequestHandler<GetOutfitImagesQuery, List<OutfitImageReadDTO>>
{
    private readonly IOutfitImageRepository _outfitImageRepository;
    private readonly IOutfitRepository _outfitRepository;
    private readonly IMapper _mapper;

    public GetOutfitImagesQueryHandler(IOutfitImageRepository outfitImageRepository, IOutfitRepository outfitRepository, IMapper mapper)
    {
        _outfitImageRepository = outfitImageRepository;
        _outfitRepository = outfitRepository;
        _mapper = mapper;
    }

    public async Task<List<OutfitImageReadDTO>> Handle(GetOutfitImagesQuery request, CancellationToken cancellationToken)
    {
        if (await _outfitRepository.GetByIdAsync(request.OutfitId) == null) throw new NotFoundException("There is no outfit with the given Id.");
        var outfitImages = await _outfitImageRepository.GetAllOutfitImagesAsync(request.OutfitId);
        return _mapper.Map<List<OutfitImageReadDTO>>(outfitImages);
    }
}
