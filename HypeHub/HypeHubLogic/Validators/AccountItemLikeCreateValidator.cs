using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.AccountItemLike;

namespace HypeHubLogic.Validators;

public class AccountItemLikeCreateValidator : AbstractValidator<AccountItemLikeCreateDTO>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IItemRepository _itemRepository;

    public AccountItemLikeCreateValidator(IAccountRepository accountRepository, IItemRepository itemRepository)
    {
        _accountRepository = accountRepository;
        _itemRepository = itemRepository;

        RuleFor(ail => ail.AccountId)
            .NotEmpty()
            .WithMessage("AccountId must have a value.")
            .MustAsync(CheckIfGuidValue)
            .WithMessage("AccountId must be a valid GUID.")
            .MustAsync(CheckIfAccountExist)
            .WithMessage("There is no account with the given Id.");

        RuleFor(ail => ail.ItemId)
            .NotEmpty()
            .WithMessage("ItemId must have a value.")
            .MustAsync(CheckIfGuidValue)
            .WithMessage("ItemId must be a valid GUID.")
            .MustAsync(CheckIfItemExist)
            .WithMessage("There is no item with the given Id.");
    }

    private async Task<bool> CheckIfAccountExist(Guid id, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetByIdAsync(id);
        return account != null;
    }

    private async Task<bool> CheckIfItemExist(Guid id, CancellationToken cancellationToken)
    {
        var item = await _itemRepository.GetByIdAsync(id);
        return item != null;
    }

    private async Task<bool> CheckIfGuidValue<T>(T value, CancellationToken cancellationToken)
    {
        return await Task.FromResult(typeof(Guid) == value.GetType());
    }
}
