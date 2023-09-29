using HypeHubLogic.DTOs.Item;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Update;

public class UpdateItemCommand : IRequest<ItemGenerallReadDTO>
{
    public ItemUpdateDTO Item { get; init; }

    public UpdateItemCommand(ItemUpdateDTO item)
    {
        Item = item;
    }
}
