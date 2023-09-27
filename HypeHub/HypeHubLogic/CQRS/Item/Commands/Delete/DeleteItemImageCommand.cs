using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Delete;

public class DeleteItemImageCommand : IRequest
{
    public Guid ItemImageId { get; init; }

    public DeleteItemImageCommand(Guid itemImageId)
    {
        ItemImageId = itemImageId;
    }
}
