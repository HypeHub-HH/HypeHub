using HypeHubLogic.DTOs.Item;
using HypeHubLogic.Response;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HypeHubLogic.CQRS.Item.Commands.Update;

public class UpdateItemCommand : IRequest<BaseResponse<ItemReadDTO>>
{
    public ItemCreateDTO Item { get; set; }
    public Guid ItemId { get; set; }
    public UpdateItemCommand(ItemCreateDTO item, Guid itemId)
    {
        Item = item;
        ItemId = itemId;
    }
}
