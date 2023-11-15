using MediatR;

namespace HypeHubLogic.CQRS.Item.Queries;
public class GetCheckIfItemIsInAnyOutfitCommand : IRequest<bool>
{
    public Guid ItemId { get; init; }
    public GetCheckIfItemIsInAnyOutfitCommand(Guid itemId)
    {
        ItemId = itemId;
    }
}
