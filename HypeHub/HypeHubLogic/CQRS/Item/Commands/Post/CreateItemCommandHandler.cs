using AutoMapper;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Item;
using HypeHubLogic.Response;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Post;

public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, BaseResponse<ItemReadDTO>>
{
    private readonly IItemRepository _itemRepository;
    private readonly IMapper _mapper;

    public CreateItemCommandHandler(IItemRepository itemRepository, IMapper mapper)
    {
        _itemRepository = itemRepository;
        _mapper = mapper;
    }

    public async Task<BaseResponse<ItemReadDTO>> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        var item = _mapper.Map<HypeHubDAL.Models.Item>(request.Item);
        item = await _itemRepository.AddAsync(item);
        var addedItem = _mapper.Map<ItemReadDTO>(item);
        return new BaseResponse<ItemReadDTO>(addedItem);
    }
}
