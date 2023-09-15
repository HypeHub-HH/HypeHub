using HypeHubLogic.DTOs.Item;
using HypeHubLogic.Response;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Update;

public class UpdateItemCommand : IRequest<BaseResponse<ItemReadDTO>>
{
    public ItemCreateDTO Item { get; init; }
    public Guid ItemId { get; init; }

    public UpdateItemCommand(ItemCreateDTO item, Guid itemId)
    {
        Item = item;
        ItemId = itemId;
    }
}
