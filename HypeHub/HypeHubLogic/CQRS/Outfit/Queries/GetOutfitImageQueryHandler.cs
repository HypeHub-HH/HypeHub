using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;

public class GetOutfitImageQueryHandler : IRequestHandler<GetOutfitImageQuery, OutfitImageReadDTO>
{
    private readonly IOutfitImageRepository _outfitImageRepository;
    private readonly IMapper _mapper;

    public GetOutfitImageQueryHandler(IOutfitImageRepository outfitImageRepository, IMapper mapper)
    {
        _outfitImageRepository = outfitImageRepository;
        _mapper = mapper;
    }

    public async Task<OutfitImageReadDTO> Handle(GetOutfitImageQuery request, CancellationToken cancellationToken)
    {
        var outfitImage = await _outfitImageRepository.GetByIdAsync(request.OutfitImageId) ?? throw new NotFoundException($"There is no image with the given Id: {request.OutfitImageId}.");
        return _mapper.Map<OutfitImageReadDTO>(outfitImage);
    }
}