using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Outfit;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Update;

public class UpdateOutfitCommandHandler : IRequestHandler<UpdateOutfitCommand, OutfitReadDTO>
{
    private readonly IOutfitRepository _outfitRepository;
    private readonly IMapper _mapper;
    private readonly IValidator<OutfitUpdateDTO> _validator;

    public UpdateOutfitCommandHandler(IOutfitRepository outfitRepository, IMapper mapper, IValidator<OutfitUpdateDTO> validator)
    {
        _outfitRepository = outfitRepository;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<OutfitReadDTO> Handle(UpdateOutfitCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request.Outfit);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult.Errors.Select(error => error.ErrorMessage));
        var currentOutfit = await _outfitRepository.GetByIdAsync(request.Outfit.Id) ?? throw new NotFoundException($"There is no outfit with the given Id: {request.Outfit.Id}.");
        currentOutfit.Name = request.Outfit.Name;
        var updatedOutfit = await _outfitRepository.UpdateAsync(currentOutfit);
        return _mapper.Map<OutfitReadDTO>(updatedOutfit);
    }
}