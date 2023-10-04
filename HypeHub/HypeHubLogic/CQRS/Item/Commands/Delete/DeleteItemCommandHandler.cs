using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.Validators;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Delete;

public class DeleteItemCommandHandler : IRequestHandler<DeleteItemCommand>
{
    private readonly IItemRepository _itemRepository;
    private readonly IOwnershipValidator _ownershipValidator;

    public DeleteItemCommandHandler(IItemRepository itemRepository, IMapper mapper, IOwnershipValidator ownershipValidator)
    {
        _itemRepository = itemRepository;
        _ownershipValidator = ownershipValidator;
    }

    public async Task Handle(DeleteItemCommand request, CancellationToken cancellationToken)
    {
        if (!await _ownershipValidator.ValidateOwnership(request.Claims, request.ItemId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint");
        var item = await _itemRepository.GetByIdAsync(request.ItemId) ?? throw new NotFoundException($"There is no item with the given ID: {request.ItemId}.");
        await _itemRepository.DeleteAsync(item);
    }
}
