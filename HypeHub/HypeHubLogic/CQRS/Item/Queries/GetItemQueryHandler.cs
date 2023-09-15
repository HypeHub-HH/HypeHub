using AutoMapper;
using HypeHubDAL.Models.Types;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Item;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Queries;

public class GetItemQueryHandler : IRequestHandler<GetItemQuery, ItemReadDTO>
{
    private readonly IItemRepository _itemRepository;
    private readonly IMapper _mapper;

    public GetItemQueryHandler(IItemRepository itemRepository, IMapper mapper)
    {
        _itemRepository = itemRepository;
        _mapper = mapper;
    }

    public async Task<ItemReadDTO> Handle(GetItemQuery request, CancellationToken cancellationToken)
    {
        var item = await _itemRepository.GetByIdAsync(request.ItemId);
        return _mapper.Map<ItemReadDTO>(item);
    }
}