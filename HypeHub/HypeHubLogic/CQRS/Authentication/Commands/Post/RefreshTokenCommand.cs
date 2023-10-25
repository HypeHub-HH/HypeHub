using HypeHubDAL.Models;
using MediatR;

namespace HypeHubLogic.CQRS.Authentication.Commands.Post;
public class RefreshTokenCommand : IRequest<string>
{
    public Token Token { get; init; }
    public RefreshTokenCommand(Token token)
    {
        Token = token;
    }
}
