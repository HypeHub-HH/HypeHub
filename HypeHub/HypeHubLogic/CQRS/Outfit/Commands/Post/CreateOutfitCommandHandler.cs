using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Outfit;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;

public class CreateOutfitCommandHandler : IRequestHandler<CreateOutfitCommand, OutfitReadDTO>
{
    private readonly IOutfitRepository _outfitRepository;
    private readonly IMapper _mapper;
    private readonly IValidator<OutfitCreateDTO> _validator;

    public CreateOutfitCommandHandler(IOutfitRepository outfitRepository, IMapper mapper, IValidator<OutfitCreateDTO> validator)
    {
        _outfitRepository = outfitRepository;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<OutfitReadDTO> Handle(CreateOutfitCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request.Outfit);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult);
        var outfit = _mapper.Map<HypeHubDAL.Models.Outfit>(request.Outfit);
        var createdOutfit = await _outfitRepository.AddAsync(outfit);
        return _mapper.Map<OutfitReadDTO>(createdOutfit);
    }
}