using MediatR;

namespace HypeHubLogic.CQRS.Account.Queries;
public class CheckIfUsernameAlreadyExistQuery : IRequest<bool>
{
    public string Username { get; set; }
    public CheckIfUsernameAlreadyExistQuery(string username)
    {
        Username = username;
    }
}