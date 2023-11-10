using HypeHubLogic.DTOs.Account;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Account.Commands.Update;
public class UpdateAccountPrivacyCommand : IRequest<AccountGeneralInfoReadDTO>
{
    public IEnumerable<Claim> Claims { get; set; }
    public AccountUpdatePrivacyDTO Account { get; set; }
    public UpdateAccountPrivacyCommand(IEnumerable<Claim> claims, AccountUpdatePrivacyDTO account)
    {
        Claims = claims;
        Account = account;
    }
}
