using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Outfit;
using MediatR;
using System.Security.Claims;
namespace HypeHubLogic.CQRS.Outfit.Commands.Post;
public class CreateOutfitCommandHandler : IRequestHandler<CreateOutfitCommand, OutfitGenerallReadDTO>
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
    public async Task<OutfitGenerallReadDTO> Handle(CreateOutfitCommand request, CancellationToken cancellationToken)
    {
        var userId = Guid.Parse(request.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value);
        var validationResult = await _validator.ValidateAsync(request.Outfit);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult.Errors.Select(error => error.ErrorMessage));
        var outfit = new HypeHubDAL.Models.Outfit(userId, request.Outfit.Name);
        var createdOutfit = await _outfitRepository.AddAsync(outfit);
        return _mapper.Map<OutfitGenerallReadDTO>(createdOutfit);
    }
}