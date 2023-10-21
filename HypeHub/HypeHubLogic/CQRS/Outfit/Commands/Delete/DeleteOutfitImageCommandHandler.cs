using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.Validators;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Delete;
public class DeleteOutfitImageCommandHandler : IRequestHandler<DeleteOutfitImageCommand>
{
    private readonly IOutfitImageRepository _outfitImageRepository;
    private readonly IOwnershipValidator _ownershipValidator;
    public DeleteOutfitImageCommandHandler(IOutfitImageRepository outfitImageRepository, IOwnershipValidator ownershipValidator)
    {
        _outfitImageRepository = outfitImageRepository;
        _ownershipValidator = ownershipValidator;
    }
    public async Task Handle(DeleteOutfitImageCommand request, CancellationToken cancellationToken)
    {
        var outfitImage = await _outfitImageRepository.GetByIdAsync(request.OutfitImageId) ?? throw new NotFoundException($"There is no Image with the given Id: {request.OutfitImageId}.");
        if (!await _ownershipValidator.ValidateOwnership(request.Claims, outfitImage.OutfitId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint");
        await _outfitImageRepository.DeleteAsync(outfitImage);
    }
}