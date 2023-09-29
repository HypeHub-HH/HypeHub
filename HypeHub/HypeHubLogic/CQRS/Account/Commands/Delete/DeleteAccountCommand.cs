using MediatR;

namespace HypeHubLogic.CQRS.Account.Commands.Delete;

public class DeleteAccountCommand : IRequest
{
    public Guid AccountId { get; set; }
    public DeleteAccountCommand(Guid accountId)
    {
        AccountId = accountId;
    }

}
