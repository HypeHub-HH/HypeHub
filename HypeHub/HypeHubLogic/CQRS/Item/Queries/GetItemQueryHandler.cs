using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Item;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Queries;
public class GetItemQueryHandler : IRequestHandler<GetItemQuery, ItemGenerallReadDTO>
{
    private readonly IItemRepository _itemRepository;
    private readonly IMapper _mapper;
    public GetItemQueryHandler(IItemRepository itemRepository, IMapper mapper)
    {
        _itemRepository = itemRepository;
        _mapper = mapper;
    }
    public async Task<ItemGenerallReadDTO> Handle(GetItemQuery request, CancellationToken cancellationToken)
    {
        var item = await _itemRepository.GetByIdAsync(request.ItemId) ?? throw new NotFoundException($"There is no item with the given Id: {request.ItemId}.");
        return _mapper.Map<ItemGenerallReadDTO>(item);
    }
}