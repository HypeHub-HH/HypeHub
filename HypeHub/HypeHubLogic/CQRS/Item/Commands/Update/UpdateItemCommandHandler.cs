using AutoMapper;
using HypeHubDAL.Repositories.Interfaces;
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
        var itemForUpdate = await _itemRepository.GetByIdAsync(request.ItemId);
        var update = request.Item;

        itemForUpdate.Name = update.Name;
        itemForUpdate.CloathingType = update.CloathingType;
        itemForUpdate.Brand = update.Brand;
        itemForUpdate.Model = update.Model;
        itemForUpdate.Colorway = update.Colorway;
        itemForUpdate.Price = update.Price;
        itemForUpdate.PurchaseDate = update.PurchaseDate;

        var item = await _itemRepository.UpdateAsync(itemForUpdate);
        var updatedItem = _mapper.Map<ItemReadDTO>(item);

        return new BaseResponse<ItemReadDTO>(updatedItem);
    }
}
