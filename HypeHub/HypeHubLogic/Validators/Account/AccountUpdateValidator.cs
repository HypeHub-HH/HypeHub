using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;

namespace HypeHubLogic.Validators.Account;
public class AccountUpdateValidator : AbstractValidator<AccountUpdateDTO>
{
    private readonly IAccountRepository _accountRepository;
    public AccountUpdateValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleFor(a => a.Id)
            .NotEmpty()
            .WithMessage("Id must have a value.")
            .MustAsync(CheckIfAccountExist)
            .WithMessage("There is no account with the given Id.");

        When(a => a.Username != null, () =>
        {
            RuleFor(a => a.Username)
                .NotEmpty()
                .WithMessage("Username must have a value.")
                .Length(4, 15)
                .WithMessage("Username must not have less than 4 and more than 15 characters.")
                .MustAsync(CheckIfUsernameAlreadyExist)
                .WithMessage("Account with this Username already exist.");
        });

        When(a => a.AvatarUrl != null, () =>
        {
            RuleFor(a => a.AvatarUrl)
                .MaximumLength(400)
                .WithMessage("AvatarUrl must not have more than 400 characters.")
                .Matches(@"^(https?://)?([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$")
                .WithMessage("AvatarUrl is not in a valid format.");
        });
    }
    private async Task<bool> CheckIfAccountExist(Guid id, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetByIdAsync(id);
        return account != null;
    }
    private async Task<bool> CheckIfUsernameAlreadyExist(string username, CancellationToken cancellationToken)
    {
        return !await _accountRepository.CheckIfUsernameAlreadyExistAsync(username);
    }
}
