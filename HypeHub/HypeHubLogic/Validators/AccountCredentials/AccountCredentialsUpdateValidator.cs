using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.AccountCredentials;

namespace HypeHubLogic.Validators.AccountCredentials;

public class AccountCredentialsUpdateValidator : AbstractValidator<AccountCredentialsUpdateDTO>
{
    private readonly IAccountCredentialsRepository _accountCredentialsRepository;

    public AccountCredentialsUpdateValidator(IAccountCredentialsRepository accountCredentialsRepository)
    {
        _accountCredentialsRepository = accountCredentialsRepository;

        RuleFor(ac => ac.Id)
            .NotEmpty()
            .WithMessage("Id must have a value.")
            .MustAsync(CheckIfGuidValue)
            .WithMessage("Id must be a valid GUID.")
            .MustAsync(CheckIfAccountCredentialsExist)
            .WithMessage("There is no credentials with the given Id.");

        When(ac => ac.Password != null, () =>
        {
            RuleFor(ac => ac.Password)
                .NotEmpty()
                .WithMessage("Password must have a value.")
                .Length(4, 255)
                .WithMessage("Password must not have less than 4 and more than 255 characters.");
        });

        When(ac => ac.Email != null, () =>
        {
            RuleFor(ac => ac.Email)
                .NotEmpty()
                .WithMessage("Email must have a value.")
                .MaximumLength(255)
                .WithMessage("Email must not have more than 255 characters.")
                .EmailAddress()
                .WithMessage("Email must be in a valid email format.")
                .MustAsync(CheckIfEmailAlreadyExist)
                .WithMessage("Account with this Email already exist.");
        });
    }

    private async Task<bool> CheckIfAccountCredentialsExist(Guid id, CancellationToken cancellationToken)
    {
        var accountCredentials = await _accountCredentialsRepository.GetByIdAsync(id);
        return accountCredentials != null;
    }

    private async Task<bool> CheckIfGuidValue<T>(T value, CancellationToken cancellationToken)
    {
        return await Task.FromResult(typeof(Guid) == value.GetType());
    }

    private async Task<bool> CheckIfEmailAlreadyExist(string email, CancellationToken cancellationToken)
    {
        return !await _accountCredentialsRepository.CheckIfEmailAlreadyExistAsync(email);
    }
}
