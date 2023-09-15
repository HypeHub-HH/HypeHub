using AutoMapper;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.CQRS.Item.Commands.Post;
using HypeHubLogic.DTOs.Item;
using HypeHubLogic.Response;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Update;

public class UpdateItemCommandHandler : IRequestHandler<UpdateItemCommand, BaseResponse<ItemReadDTO>>
{
    private readonly IItemRepository _itemRepository;
    private readonly IMapper _mapper;

    public UpdateItemCommandHandler(IItemRepository itemRepository, IMapper mapper)
    {
        _itemRepository = itemRepository;
        _mapper = mapper;
    }

    public async Task<BaseResponse<ItemReadDTO>> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
    {
        //var itemForUpdate = await _itemRepository.GetByIdAsync(request.ItemId);

        //var itemmmm = _mapper.Map<HypeHubDAL.Models.Item>(request.Item);

        
        //itemmmm.Id = itemForUpdate.Id;



        //var item = await _itemRepository.UpdateAsync(itemmmm);
        //var updatedItem = _mapper.Map<ItemReadDTO>(item);
        return new BaseResponse<ItemReadDTO>();
    }
}
