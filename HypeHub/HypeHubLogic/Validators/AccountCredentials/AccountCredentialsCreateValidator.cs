using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.AccountCredentials;

namespace HypeHubLogic.Validators.AccountCredentials;

public class AccountCredentialsCreateValidator : AbstractValidator<AccountCredentialsCreateDTO>
{
    private readonly IAccountCredentialsRepository _accountCredentialsRepository;

    public AccountCredentialsCreateValidator(IAccountCredentialsRepository accountCredentialsRepository)
    {
        _accountCredentialsRepository = accountCredentialsRepository;

        RuleFor(ac => ac.Password)
            .NotEmpty()
            .WithMessage("Password must have a value.")
            .Length(4, 255)
            .WithMessage("Password must not have less than 4 and more than 255 characters.");

        RuleFor(ac => ac.Email)
            .NotEmpty()
            .WithMessage("Email must have a value.")
            .MaximumLength(255)
            .WithMessage("Email must not have more than 255 characters.")
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