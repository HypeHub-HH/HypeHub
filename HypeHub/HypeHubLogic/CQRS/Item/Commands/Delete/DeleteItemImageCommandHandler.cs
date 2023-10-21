using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.Validators;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Delete;
public class DeleteItemImageCommandHandler : IRequestHandler<DeleteItemImageCommand>
{
    private readonly IItemImageRepository _itemImageRepository;
    private readonly IOwnershipValidator _ownershipValidator;
    public DeleteItemImageCommandHandler(IItemImageRepository itemImageRepository, IOwnershipValidator ownershipValidator)
    {
        _itemImageRepository = itemImageRepository;
        _ownershipValidator = ownershipValidator;
    }
    public async Task Handle(DeleteItemImageCommand request, CancellationToken cancellationToken)
    {     
        var itemImage = await _itemImageRepository.GetByIdAsync(request.ItemImageId) ?? throw new NotFoundException($"There is no Image with the given Id: {request.ItemImageId}.");
        if (!await _ownershipValidator.ValidateOwnership(request.Claims, itemImage.ItemId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint");    
        await _itemImageRepository.DeleteAsync(itemImage);
    }
}
