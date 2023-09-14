using HypeHubLogic.Response;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Post;

public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, BaseResponse>
{
    public Task<BaseResponse> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
