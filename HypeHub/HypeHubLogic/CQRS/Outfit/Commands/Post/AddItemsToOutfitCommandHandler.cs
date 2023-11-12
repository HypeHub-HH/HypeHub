using HypeHubDAL.Exeptions;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.Validators;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;
public class AddItemsToOutfitCommandHandler : IRequestHandler<AddItemsToOutfitCommand, List<OutfitItem>>
{

    private readonly IOutfitItemRepository _outfitItemeRepository;
    private readonly IOwnershipValidator _ownershipValidator;

    public AddItemsToOutfitCommandHandler(IOutfitItemRepository outfitItemeRepository, IOwnershipValidator ownershipValidator)
    {
        _outfitItemeRepository = outfitItemeRepository;
        _ownershipValidator = ownershipValidator;
    }
    public async Task<List<OutfitItem>> Handle(AddItemsToOutfitCommand request, CancellationToken cancellationToken)
    {
        if (!await _ownershipValidator.ValidateOwnership(request.Claims, request.OutfitId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint.");
        var addedItems = new List<OutfitItem>();
        if (request.Items.Count>0)
        {
            foreach (var itemId in request.Items)
            {
                if (!await _ownershipValidator.ValidateOwnership(request.Claims, itemId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint.");
            }
            foreach (var itemId in request.Items)
            {
                var createdOutfitItem = await _outfitItemeRepository.AddAsync(new OutfitItem(request.OutfitId, itemId)) ?? throw new InternalEntityServerException("Server failed", new List<string>() { "OutfitItem has not been created." });
                addedItems.Add(createdOutfitItem);
            }
        }
        return addedItems;
    }
}
