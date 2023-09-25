using HypeHubLogic.DTOs.Item;
using HypeHubLogic.Response;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Update;

public class UpdateItemCommand : IRequest<ItemReadDTO>
{
    public ItemUpdateDTO Item { get; init; }

    public UpdateItemCommand(ItemUpdateDTO item)
    {
        Item = item;
    }
}
