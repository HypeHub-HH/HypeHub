using HypeHubLogic.DTOs.Account;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Account.Commands.Update;
public class UpdateAccountAvatarCommand : IRequest<AccountGeneralInfoReadDTO>
{
    public IEnumerable<Claim> Claims { get; set; }
    public AccountUpdateAvatarDTO Account { get; set; }
    public UpdateAccountAvatarCommand(IEnumerable<Claim> claims, AccountUpdateAvatarDTO account)
    {
        Claims = claims;
        Account = account;
    }
}
