using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.Validators;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;
public class RemoveItemsFromOutfitCommandHandler : IRequestHandler<RemoveItemsFromOutfitCommand>
{

    private readonly IOutfitItemRepository _outfitItemeRepository;
    private readonly IOwnershipValidator _ownershipValidator;

    public RemoveItemsFromOutfitCommandHandler(IOutfitItemRepository outfitItemeRepository, IOwnershipValidator ownershipValidator)
    {
        _outfitItemeRepository = outfitItemeRepository;
        _ownershipValidator = ownershipValidator;
    }
    public async Task Handle(RemoveItemsFromOutfitCommand request, CancellationToken cancellationToken)
    {
        if (!await _ownershipValidator.ValidateOwnership(request.Claims, request.OutfitId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint.");
        if (request.Items.Count > 0)
        {
            foreach (var itemId in request.Items)
            {
                if (!await _ownershipValidator.ValidateOwnership(request.Claims, itemId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint.");
            }
            foreach (var itemId in request.Items)
            {
                await _outfitItemeRepository.DeleteAsync(new OutfitItem(request.OutfitId, itemId));
            }
        }
    }
}