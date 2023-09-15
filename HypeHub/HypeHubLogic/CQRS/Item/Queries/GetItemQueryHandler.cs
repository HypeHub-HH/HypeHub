using HypeHubLogic.DTOs.Item;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Queries;

public class GetItemQueryHandler : IRequestHandler<GetItemQuery, ItemReadDTO>
{
    public Task<ItemReadDTO> Handle(GetItemQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
