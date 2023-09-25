using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Delete;

public class DeleteItemCommand : IRequest
{
    public Guid ItemId { get; init; }

    public DeleteItemCommand(Guid itemId)
    {
        ItemId = itemId;
    }
}
