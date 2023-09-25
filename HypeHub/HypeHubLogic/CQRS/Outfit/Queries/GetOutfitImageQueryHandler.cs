using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;

public class GetOutfitImageQueryHandler : IRequestHandler<GetOutfitImageQuery, OutfitImageReadDTO>
{
    private readonly IOutfitRepository _outfitRepository;
    private readonly IMapper _mapper;

    public GetOutfitImageQueryHandler(IOutfitRepository outfitRepository, IMapper mapper)
    {
        _outfitRepository = outfitRepository;
        _mapper = mapper;
    }

    public async Task<OutfitImageReadDTO> Handle(GetOutfitImageQuery request, CancellationToken cancellationToken)
    {
        var outfitImage = await _outfitRepository.GetOutfitImageByIdAsync(request.OutfitId, request.OutfitImageId);
        return _mapper.Map<OutfitImageReadDTO>(outfitImage) ?? throw new NotFoundException("There is no image with the given Id.");
    }
}