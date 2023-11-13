using HypeHubDAL.Exeptions;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.Validators;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;
public class AddItemToOutfitCommandHandler : IRequestHandler<AddItemToOutfitCommand, OutfitItem>
{

    private readonly IOutfitItemRepository _outfitItemeRepository;
    private readonly IOwnershipValidator _ownershipValidator;

    public AddItemToOutfitCommandHandler(IOutfitItemRepository outfitItemeRepository, IOwnershipValidator ownershipValidator)
    {
        _outfitItemeRepository = outfitItemeRepository;
        _ownershipValidator = ownershipValidator;
    }
    public async Task<OutfitItem> Handle(AddItemToOutfitCommand request, CancellationToken cancellationToken)
    {
        if (!await _ownershipValidator.ValidateOwnership(request.Claims, request.OutfitId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint.");
        if (!await _ownershipValidator.ValidateOwnership(request.Claims, request.ItemId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint.");
        var createdOutfitItem = await _outfitItemeRepository.AddAsync(new OutfitItem(request.OutfitId, request.ItemId)) ?? throw new InternalEntityServerException("Server failed", new List<string>() { "OutfitItem has not been created." });
        return createdOutfitItem;
    }
}
