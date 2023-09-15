﻿using AutoMapper;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Item;
using HypeHubLogic.Response;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Delete;

public class DeleteItemCommandHandler : IRequestHandler<DeleteItemCommand, BaseResponse<ItemReadDTO>>
{
    private readonly IItemRepository _itemRepository;
    private readonly IMapper _mapper;

    public DeleteItemCommandHandler(IItemRepository itemRepository, IMapper mapper)
    {
        _itemRepository = itemRepository;
        _mapper = mapper;
    }

    public async Task<BaseResponse<ItemReadDTO>> Handle(DeleteItemCommand request, CancellationToken cancellationToken)
    {
        var itemForDelete = await _itemRepository.GetByIdAsync(request.ItemId);

        var item = await _itemRepository.DeleteAsync(itemForDelete);
        var deletedItem = _mapper.Map<ItemReadDTO>(item);

        return new BaseResponse<ItemReadDTO>(deletedItem);
    }
}