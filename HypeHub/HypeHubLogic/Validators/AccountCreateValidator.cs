using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;

namespace HypeHubLogic.Validators;

public class AccountCreateValidator : AbstractValidator<AccountCreateDTO>
{
    private readonly IAccountRepository _accountRepository;

    public AccountCreateValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleFor(a => a.Username)
            .NotEmpty()
            .WithMessage("Username must have a value.")
            .Length(4, 15)
            .WithMessage("Username must not have less than 4 and more than 15 characters.")
            .MustAsync(CheckIfUsernameAlreadyExist)
            .WithMessage("Account with this Username already exist.");

        RuleFor(a => a.IsPrivate)
            .NotEmpty()
            .WithMessage("IsPrivate must have a value.")
            .MustAsync(CheckIfBooleanValue)
            .WithMessage("IsPrivate must be a valid boolean value.");

        When(a => a.AvatarUrl != null, () =>
        {
            RuleFor(a => a.AvatarUrl)
                .MaximumLength(400)
                .WithMessage("AvatarUrl must not have more than 400 characters.")
                .Matches(@"^(https?://)?([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$")
                .WithMessage("AvatarUrl is not in a valid format.");
        });

    }

    private async Task<bool> CheckIfUsernameAlreadyExist(string username, CancellationToken cancellationToken)
    {
        return !await _accountRepository.CheckIfUsernameAlreadyExistAsync(username);
    }

    private async Task<bool> CheckIfBooleanValue<T>(T value, CancellationToken cancellationToken)
    {
        return await Task.FromResult(typeof(T) == typeof(bool));
    }
}

