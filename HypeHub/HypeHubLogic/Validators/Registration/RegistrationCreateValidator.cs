using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Registration;
using Microsoft.AspNetCore.Identity;

namespace HypeHubLogic.Validators.Registration;

public class RegistrationCreateValidator : AbstractValidator<RegistrationCreateDTO>
{
    private readonly IAccountRepository _accountRepository;
    private readonly UserManager<IdentityUser> _userManager;

    public RegistrationCreateValidator(IAccountRepository accountRepository, UserManager<IdentityUser> userManager)
    {
        _accountRepository = accountRepository;
        _userManager = userManager;

        RuleFor(r => r.Username)
            .NotEmpty()
            .WithMessage("Username must have a value.")
            .Length(4, 15)
            .WithMessage("Username must not have less than 4 and more than 15 characters.")
            .MustAsync(CheckIfUsernameAlreadyExist)
            .WithMessage("Account with this Username already exist.");

        RuleFor(r => r.Password)
            .NotEmpty()
            .WithMessage("Password must have a value.")
            .Length(6, 255)
            .WithMessage("Password must not have less than 4 and more than 255 characters.")
            .Matches(@"[A-Z]")
            .WithMessage("Password must contain at least one uppercase letter.")
            .Matches(@"[a-z]")
            .WithMessage("Password must contain at least one lowercase letter.")
            .Matches(@"\d")
            .WithMessage("Password must contain at least one digit.")
            .Matches(@"\W")
            .WithMessage("Password must contain at least one non-alphanumeric character.");

        RuleFor(r => r.Email)
             .NotEmpty()
             .WithMessage("Email must have a value.")
             .MaximumLength(255)
             .WithMessage("Email must not have more than 255 characters.")
             .EmailAddress()
             .WithMessage("Email must be in a valid email format.")
             .MustAsync(CheckIfEmailAlreadyExist)
             .WithMessage("Account with this Email already exist.");
    }

    private async Task<bool> CheckIfUsernameAlreadyExist(string username, CancellationToken cancellationToken)
    {
        return !await _accountRepository.CheckIfUsernameAlreadyExistAsync(username);
    }

    private async Task<bool> CheckIfEmailAlreadyExist(string email, CancellationToken cancellationToken)
    {
        return await _userManager.FindByEmailAsync(email) == null;
    }
}

