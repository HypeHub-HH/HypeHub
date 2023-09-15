using HypeHubLogic.DTOs.Item;
using HypeHubLogic.Response;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Post;

public class CreateItemCommand : IRequest<BaseResponse<ItemReadDTO>>
{
    public ItemCreateDTO Item { get; init; }

    public CreateItemCommand(ItemCreateDTO item)
    {
        Item = item;
    }
}
