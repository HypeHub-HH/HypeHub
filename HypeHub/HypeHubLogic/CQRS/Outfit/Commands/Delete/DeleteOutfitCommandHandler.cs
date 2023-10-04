using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.Validators;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Delete;

public class DeleteOutfitCommandHandler : IRequestHandler<DeleteOutfitCommand>
{
    private readonly IOutfitRepository _outfitRepository;
    private readonly IOwnershipValidator _ownershipValidator;

    public DeleteOutfitCommandHandler(IOutfitRepository outfitRepository, IOwnershipValidator ownershipValidator)
    {
        _outfitRepository = outfitRepository;
        _ownershipValidator = ownershipValidator;
    }

    public async Task Handle(DeleteOutfitCommand request, CancellationToken cancellationToken)
    {
        if (!await _ownershipValidator.ValidateOwnership(request.Claims, request.OutfitId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint");
        var outfit = await _outfitRepository.GetByIdAsync(request.OutfitId) ?? throw new NotFoundException($"There is no outfit with the given Id: {request.OutfitId}.");
        await _outfitRepository.DeleteAsync(outfit);
    }
}