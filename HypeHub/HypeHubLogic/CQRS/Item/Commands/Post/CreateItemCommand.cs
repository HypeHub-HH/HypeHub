using HypeHubLogic.DTOs.Item;
using HypeHubLogic.Response;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Post;

public class CreateItemCommand : IRequest<BaseResponse>
{
    public ItemCreateDTO Item { get; set; }
    public CreateItemCommand(ItemCreateDTO item)
    {
        Item = item;
    }
}
