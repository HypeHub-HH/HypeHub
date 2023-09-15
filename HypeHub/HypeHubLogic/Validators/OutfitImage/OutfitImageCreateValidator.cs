using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.OutfitImage;

namespace HypeHubLogic.Validators.OutfitImage;

public class OutfitImageCreateValidator : AbstractValidator<OutfitImageCreateDTO>
{
    private readonly IOutfitRepository _outfitRepository;

    public OutfitImageCreateValidator(IOutfitRepository outfitRepository)
    {
        _outfitRepository = outfitRepository;

        RuleFor(oi => oi.OutfitId)
            .NotEmpty()
            .WithMessage("OutfitId must have a value.")
            .MustAsync(CheckIfGuidValue)
            .WithMessage("OutfitId must be a valid GUID.")
            .MustAsync(CheckIfOutfitExist)
            .WithMessage("There is no outfit with the given Id.");

        RuleFor(oi => oi.Url)
            .MaximumLength(400)
            .WithMessage("Url must not have more than 400 characters.")
            .Matches(@"^(https?://)?([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$")
            .WithMessage("Url is not in a valid format.");
    }

    private async Task<bool> CheckIfOutfitExist(Guid id, CancellationToken cancellationToken)
    {
        var account = await _outfitRepository.GetByIdAsync(id);
        return account != null;
    }

    private async Task<bool> CheckIfGuidValue<T>(T value, CancellationToken cancellationToken)
    {
        return await Task.FromResult(typeof(Guid) == value.GetType());
    }
}