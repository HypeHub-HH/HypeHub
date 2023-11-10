using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Outfit;
using MediatR;
using System.Security.Claims;
namespace HypeHubLogic.CQRS.Outfit.Commands.Post;
public class CreateOutfitCommandHandler : IRequestHandler<CreateOutfitCommand, OutfitGenerallReadDTO>
{
    private readonly IOutfitRepository _outfitRepository;
    private readonly IOutfitItemRepository _outfitItemRepository;
    private readonly IOutfitImageRepository _outfitImageRepository;
    private readonly IMapper _mapper;
    private readonly IValidator<OutfitCreateDTO> _validator;

    public CreateOutfitCommandHandler(IOutfitRepository outfitRepository, IOutfitItemRepository outfitItemRepository, IOutfitImageRepository outfitImageRepository, IMapper mapper, IValidator<OutfitCreateDTO> validator)
    {
        _outfitRepository = outfitRepository;
        _outfitItemRepository = outfitItemRepository;
        _outfitImageRepository = outfitImageRepository;
        _mapper = mapper;
        _validator = validator;
    }
    public async Task<OutfitGenerallReadDTO> Handle(CreateOutfitCommand request, CancellationToken cancellationToken)
    {
        var outfitName = request.Outfit.Name;
        var items = request.Outfit.Items;
        var images = request.Outfit.Images;
        var userId = Guid.Parse(request.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value);
        var validationResult = await _validator.ValidateAsync(request.Outfit);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult.Errors.Select(error => error.ErrorMessage));
        var outfit = new HypeHubDAL.Models.Outfit(userId, request.Outfit.Name);
        var createdOutfit = await _outfitRepository.AddAsync(outfit) ?? throw new InternalEntityServerException("Server failed", new List<string>() { "Outfit has not been created." });
        foreach (var itemId in items)
        {
            var addedEntity = await _outfitItemRepository.AddAsync(new HypeHubDAL.Models.Relations.OutfitItem(createdOutfit.Id, itemId)) ?? throw new InternalEntityServerException("Server failed", new List<string>() { "OutfitItem has not been created." });
        }
        foreach (var image in images)
        {
            var addedEntity = await _outfitImageRepository.AddAsync(new OutfitImage(createdOutfit.Id, image)) ?? throw new InternalEntityServerException("Server failed", new List<string>() { "OutfitImage has not been created." });
        }
        return _mapper.Map<OutfitGenerallReadDTO>(createdOutfit);
    }
}