using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Item;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Delete;

public class DeleteItemCommandHandler : IRequestHandler<DeleteItemCommand>
{
    private readonly IItemRepository _itemRepository;
    private readonly IMapper _mapper;

    public DeleteItemCommandHandler(IItemRepository itemRepository, IMapper mapper)
    {
        _itemRepository = itemRepository;
        _mapper = mapper;
    }

    public async Task Handle(DeleteItemCommand request, CancellationToken cancellationToken)
    {
        var itemForDelete = await _itemRepository.GetByIdAsync(request.ItemId);
        if(itemForDelete == null)
        {
            throw new NotFoundException($"There is no accout with given id:{request.ItemId}");
        }
        var item = await _itemRepository.DeleteAsync(itemForDelete);
        var deletedItem = _mapper.Map<ItemReadDTO>(item);
    }
}
