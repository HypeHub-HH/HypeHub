using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Item;

namespace HypeHubLogic.Validators;

public class ItemCreateValidator : AbstractValidator<ItemCreateDTO>
{
    private readonly IAccountRepository _accountRepository;

    public ItemCreateValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleFor(ac => ac.Name)
             .NotEmpty()
             .WithMessage("Name must have a value.")
             .Length(4, 30)
             .WithMessage("Name must not have less than 4 and more than 30 characters.");

        RuleFor(ail => ail.AccountId)
            .NotEmpty()
            .WithMessage("AccountId must have a value.")
            .MustAsync(CheckIfGuidValue)
            .WithMessage("AccountId must be a valid GUID.")
            .MustAsync(CheckIfAccountExist)
            .WithMessage("There is no account with the given Id.");

        RuleFor(ac => ac.CloathingType)
            .NotEmpty()
            .WithMessage("CloathingType must have a value.")
            .IsInEnum()
            .WithMessage("CloathingType is not a valid enum value.");

        RuleFor(item => item.Brand)
            .MaximumLength(30)
            .When(item => item.Brand != null)
            .WithMessage("Brand must not have more than 30 characters.");

        RuleFor(item => item.Model)
            .MaximumLength(30)
            .When(item => item.Model != null)
            .WithMessage("Model must not have more than 30 characters.");

        RuleFor(item => item.Colorway)
            .MaximumLength(30)
            .When(item => item.Colorway != null)
            .WithMessage("Colorway must not have more than 30 characters.");

        RuleFor(item => item.Price)
            .GreaterThanOrEqualTo(0)
            .When(item => item.Price != null)
            .WithMessage("Price must be a non-negative value.");

        RuleFor(item => item.PurchaseDate)
            .LessThanOrEqualTo(DateTime.Now)
            .When(item => item.PurchaseDate != null)
            .WithMessage("PurchaseDate must not be older than today");
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