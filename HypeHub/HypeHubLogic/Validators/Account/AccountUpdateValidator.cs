using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;

namespace HypeHubLogic.Validators.Account;
public class AccountUpdateValidator : AbstractValidator<AccountUpdateAvatarDTO>
{
    public AccountUpdateValidator()
    {
        When(a => a.AvatarUrl != null, () =>
        {
            RuleFor(a => a.AvatarUrl)
                .MaximumLength(400)
                .WithMessage("AvatarUrl must not have more than 400 characters.")
                .Matches(@"^(https?://)?([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$")
                .WithMessage("AvatarUrl is not in a valid format.");
        });
    }
}
