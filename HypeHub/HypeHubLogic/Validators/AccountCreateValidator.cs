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

        RuleFor(ac => ac.Username)
            .NotEmpty()
            .WithMessage("Username must have a value.")
            .Length(4, 15)
            .WithMessage("Username length must be between 4 and 15.")
            .MustAsync(CheckIfUsernameAlreadyExist)
            .WithMessage("Account with this Username already exist.");

        RuleFor(ac => ac.IsPrivate)
            .NotEmpty()
            .WithMessage("IsPrivate must have a value.")
            .MustAsync(CheckIfBooleanValue)
            .WithMessage("IsPrivate must be a valid boolean value.");

        RuleFor(ac => ac.AvatarUrl)
            .MaximumLength(400)
            .WithMessage("Maximum AvatarUrl length is 400.")
            .Matches(@"^(https?://)?([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$")
            .WithMessage("AvatarUrl is not in a valid format."); ;
    }

    private async Task<bool> CheckIfUsernameAlreadyExist(string username, CancellationToken cancellationToken)
    {
        return !await _accountRepository.CheckIfUsernameAlreadyExistAsync(username);
    }

    private async Task<bool> CheckIfBooleanValue(bool IsPrivate, CancellationToken cancellationToken)
    {
        return await Task.FromResult(IsPrivate == false || IsPrivate == true);
    }
}

