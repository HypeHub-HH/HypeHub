using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Item;

namespace HypeHubLogic.Validators.Item;
public class ItemCreateValidator : AbstractValidator<ItemCreateDTO>
{
    private readonly IAccountRepository _accountRepository;
    public ItemCreateValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleFor(i => i.Name)
             .NotEmpty()
             .WithMessage("Name must have a value.")
             .Length(2, 40)
             .WithMessage("Name must not have less than 4 and more than 30 characters.");

        RuleFor(i => i.CloathingType)
            .IsInEnum()
            .WithMessage("CloathingType is not a valid enum value.");

        RuleFor(i => i.Brand)
            .MaximumLength(40)
            .When(i => i.Brand != null)
            .WithMessage("Brand must not have more than 30 characters.");

        RuleFor(i => i.Model)
            .MaximumLength(40)
            .When(i => i.Model != null)
            .WithMessage("Model must not have more than 30 characters.");

        RuleFor(i => i.Colorway)
            .MaximumLength(40)
            .When(i => i.Colorway != null)
            .WithMessage("Colorway must not have more than 30 characters.");

        RuleFor(i => i.Price)
            .GreaterThanOrEqualTo(0)
            .When(i => i.Price != null)
            .WithMessage("Price must be a non-negative value.");

        RuleFor(i => i.PurchaseDate)
            .LessThanOrEqualTo(DateTime.Now)
            .When(i => i.PurchaseDate != null)
            .WithMessage("PurchaseDate must not be older than today");
    }
    private async Task<bool> CheckIfAccountExist(Guid id, CancellationToken cancellationToken) =>
        await _accountRepository.GetByIdAsync(id) != null;
}