using HypeHubDAL.Exeptions;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.Validators;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;
public class RemoveItemFromOutfitCommandHandler : IRequestHandler<RemoveItemFromOutfitCommand>
{

    private readonly IOutfitItemRepository _outfitItemeRepository;
    private readonly IOwnershipValidator _ownershipValidator;

    public RemoveItemFromOutfitCommandHandler(IOutfitItemRepository outfitItemeRepository, IOwnershipValidator ownershipValidator)
    {
        _outfitItemeRepository = outfitItemeRepository;
        _ownershipValidator = ownershipValidator;
    }
    public async Task Handle(RemoveItemFromOutfitCommand request, CancellationToken cancellationToken)
    {
        if (!await _ownershipValidator.ValidateOwnership(request.Claims, request.OutfitId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint.");
        if (!await _ownershipValidator.ValidateOwnership(request.Claims, request.ItemId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint.");
        await _outfitItemeRepository.DeleteAsync(new OutfitItem(request.OutfitId, request.ItemId));
    }
}
