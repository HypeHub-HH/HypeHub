using HypeHubLogic.DTOs.Item;
using HypeHubLogic.Response;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Delete;

public class DeleteItemCommand : IRequest<BaseResponse<ItemReadDTO>>
{
    public Guid ItemId { get; init; }

    public DeleteItemCommand(Guid itemId)
    {
        ItemId = itemId;
    }
}
