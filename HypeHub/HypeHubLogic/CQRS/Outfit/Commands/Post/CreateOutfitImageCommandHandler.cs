using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;

public class CreateOutfitImageCommandHandler : IRequestHandler<CreateOutfitImageCommand, OutfitImageReadDTO>
{
    private readonly IOutfitRepository _outfitRepository;
    private readonly IMapper _mapper;
    private readonly IValidator<OutfitImageCreateDTO> _validator;

    public CreateOutfitImageCommandHandler(IOutfitRepository outfitRepository, IMapper mapper, IValidator<OutfitImageCreateDTO> validator)
    {
        _outfitRepository = outfitRepository;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<OutfitImageReadDTO> Handle(CreateOutfitImageCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request.OutfitImage);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult);
        var outfitImage = _mapper.Map<HypeHubDAL.Models.OutfitImage>(request.OutfitImage);
        var createdOutfitImage = await _outfitRepository.AddOutfitImageAsync(request.OutfitId, outfitImage);
        return _mapper.Map<OutfitImageReadDTO>(createdOutfitImage);
    }
}