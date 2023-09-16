using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Outfit;

namespace HypeHubLogic.Validators.Outfit;

public class OutfitCreateValidator : AbstractValidator<OutfitCreateDTO>
{
    private readonly IAccountRepository _accountRepository;

    public OutfitCreateValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleFor(o => o.Name)
             .NotEmpty()
             .WithMessage("Name must have a value.")
             .Length(4, 30)
             .WithMessage("Name must not have less than 4 and more than 30 characters.");

        RuleFor(o => o.AccountId)
            .NotEmpty()
            .WithMessage("AccountId must have a value.")
            .MustAsync(CheckIfGuidValue)
            .WithMessage("AccountId must be a valid GUID.")
            .MustAsync(CheckIfAccountExist)
            .WithMessage("There is no account with the given Id.");
    }

    private async Task<bool> CheckIfAccountExist(Guid id, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetByIdAsync(id);
        return account != null;
    }

    private async Task<bool> CheckIfGuidValue<T>(T value, CancellationToken cancellationToken)
    {
        return await Task.FromResult(typeof(Guid) == value.GetType());
    }
}