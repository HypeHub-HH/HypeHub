using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Outfit;
using HypeHubLogic.Validators;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Update;

public class UpdateOutfitCommandHandler : IRequestHandler<UpdateOutfitCommand, OutfitGenerallReadDTO>
{
    private readonly IOutfitRepository _outfitRepository;
    private readonly IMapper _mapper;
    private readonly IValidator<OutfitUpdateDTO> _validator;
    private readonly IOwnershipValidator _ownershipValidator;

    public UpdateOutfitCommandHandler(IOutfitRepository outfitRepository, IMapper mapper, IValidator<OutfitUpdateDTO> validator, IOwnershipValidator ownershipValidator)
    {
        _outfitRepository = outfitRepository;
        _mapper = mapper;
        _validator = validator;
        _ownershipValidator = ownershipValidator;
    }

    public async Task<OutfitGenerallReadDTO> Handle(UpdateOutfitCommand request, CancellationToken cancellationToken)
    {
        if (!await _ownershipValidator.ValidateOwnership(request.Claims, request.Outfit.Id)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint");
        var validationResult = await _validator.ValidateAsync(request.Outfit);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult.Errors.Select(error => error.ErrorMessage));
        var currentOutfit = await _outfitRepository.GetByIdAsync(request.Outfit.Id) ?? throw new NotFoundException($"There is no outfit with the given Id: {request.Outfit.Id}.");
        currentOutfit.Name = request.Outfit.Name;
        var updatedOutfit = await _outfitRepository.UpdateAsync(currentOutfit);
        return _mapper.Map<OutfitGenerallReadDTO>(updatedOutfit);
    }
}