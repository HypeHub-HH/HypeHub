using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.CQRS.Outfit.Commands.Delete;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Delete;

public class DeleteItemImageCommandHandler : IRequestHandler<DeleteItemImageCommand>
{
    private readonly IItemImageRepository _itemImageRepository;

    public DeleteItemImageCommandHandler(IItemImageRepository itemImageRepository)
    {
        _itemImageRepository = itemImageRepository;
    }

    public async Task Handle(DeleteItemImageCommand request, CancellationToken cancellationToken)
    {
        var itemImage = await _itemImageRepository.GetByIdAsync(request.ItemImageId) ?? throw new NotFoundException("There is no Image with the given Id.");

        await _itemImageRepository.DeleteAsync(itemImage);
    }
}
