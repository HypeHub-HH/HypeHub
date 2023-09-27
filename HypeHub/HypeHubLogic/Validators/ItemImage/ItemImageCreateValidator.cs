using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.ItemImage;

namespace HypeHubLogic.Validators.ItemImage;

public class ItemImageCreateValidator : AbstractValidator<ItemImageCreateDTO>
{
    private readonly IItemRepository _itemRepository;

    public ItemImageCreateValidator(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;

        RuleFor(ii => ii.ItemId)
            .NotEmpty()
            .WithMessage("ItemId must have a value.")
            .MustAsync(CheckIfItemExist)
            .WithMessage("There is no item with the given Id.");

        RuleFor(ii => ii.Url)
            .MaximumLength(400)
            .WithMessage("Url must not have more than 400 characters.")
            .Matches(@"^(https?://)?([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$")
            .WithMessage("Url is not in a valid format.");
    }

    private async Task<bool> CheckIfItemExist(Guid id, CancellationToken cancellationToken)
    {
        var account = await _itemRepository.GetByIdAsync(id);
        return account != null;
    }
}