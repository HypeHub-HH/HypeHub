using HypeHubDAL.Models;
using MediatR;

namespace HypeHubLogic.CQRS.Authentication.Commands.Post;
public class GoogleAuthenticateCommand : IRequest<GoogleAuthenticateResponse>
{
    public string Token { get; init; }
    public GoogleAuthenticateCommand(string token)
    {
        Token = token;
    }
}