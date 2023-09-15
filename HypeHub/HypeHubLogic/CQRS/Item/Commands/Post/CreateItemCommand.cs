using HypeHubLogic.DTOs.Item;
using HypeHubLogic.Response;
using MediatR;
using Microsoft.AspNetCore.Http.Features;

namespace HypeHubLogic.CQRS.Item.Commands.Post;

public class CreateItemCommand : IRequest<BaseResponse<ItemReadDTO>>
{
    public ItemCreateDTO Item { get; set; }
    public CreateItemCommand(ItemCreateDTO item)
    {
        Item = item;
    }
}
