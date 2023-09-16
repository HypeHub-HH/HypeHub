﻿using FluentValidation;
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
            .MustAsync(CheckIfGuidValue)
            .WithMessage("Id must be a valid GUID.")
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

        When(a => a.IsPrivate != null, () =>
        {
            RuleFor(a => a.IsPrivate)
                .NotEmpty()
                .WithMessage("IsPrivate must have a value.")
                .MustAsync(CheckIfBooleanValue)
                .WithMessage("IsPrivate must be a valid boolean value.");
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

    private async Task<bool> CheckIfGuidValue<T>(T value, CancellationToken cancellationToken)
    {
        return await Task.FromResult(typeof(Guid) == value.GetType());
    }

    private async Task<bool> CheckIfBooleanValue<T>(T value, CancellationToken cancellationToken)
    {
        return await Task.FromResult(typeof(T) == typeof(bool));
    }
}
