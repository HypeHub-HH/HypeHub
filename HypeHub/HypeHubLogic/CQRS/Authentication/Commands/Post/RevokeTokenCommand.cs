using MediatR;

namespace HypeHubLogic.CQRS.Authentication.Commands.Post;
public class RevokeTokenCommand : IRequest
{
    public string Username { get; init; }
    public RevokeTokenCommand(string username)
    {
        Username = username;
    }
}