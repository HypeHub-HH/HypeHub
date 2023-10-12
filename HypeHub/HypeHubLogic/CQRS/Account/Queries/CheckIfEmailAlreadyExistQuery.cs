using MediatR;

namespace HypeHubLogic.CQRS.Account.Queries;

public class CheckIfEmailAlreadyExistQuery : IRequest<bool>
{
    public string Email { get; set; }

    public CheckIfEmailAlreadyExistQuery(string email)
    {
        Email = email;
    }
}