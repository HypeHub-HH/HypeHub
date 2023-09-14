using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.AccountCredentials;

namespace HypeHubLogic.Validators;

public class AccountCredentialsCreateValidator : AbstractValidator<AccountCredentialsCreateDTO>
{
    private readonly IAccountCredentialsRepository _accountCredentialsRepository;

    public AccountCredentialsCreateValidator(IAccountCredentialsRepository accountCredentialsRepository)
    {
        _accountCredentialsRepository = accountCredentialsRepository;

        RuleFor(ac => ac.Password)
            .NotEmpty()
            .WithMessage("Password must have a value.")
            .MinimumLength(4)
            .WithMessage("Maximum Password length is 4.")
            .MaximumLength(255)
            .WithMessage("Maximum Password length is 255.");

        RuleFor(ac => ac.Email)
            .NotEmpty()
            .WithMessage("Email must have a value.")
            .MaximumLength(255)
            .WithMessage("Maximum Email length is 255.")
            .EmailAddress()
            .WithMessage("Email must be in a valid email format.")
            .MustAsync(CheckIfEmailAlreadyExist)
            .WithMessage("Account with this Email already exist.");
    }

    private async Task<bool> CheckIfEmailAlreadyExist(string email, CancellationToken cancellationToken)
    {
        return !await _accountCredentialsRepository.CheckIfEmailAlreadyExistAsync(email);
    }
}