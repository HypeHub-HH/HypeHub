﻿using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Outfit;

namespace HypeHubLogic.Validators.Outfit;

public class OutfitUpdateValidator : AbstractValidator<OutfitUpdateDTO>
{
    private readonly IOutfitRepository _outfitRepository;

    public OutfitUpdateValidator(IOutfitRepository outfitRepository)
    {
        _outfitRepository = outfitRepository;

        RuleFor(o => o.Id)
            .NotEmpty()
            .WithMessage("Id must have a value.")
            .MustAsync(CheckIfGuidValue)
            .WithMessage("Id must be a valid GUID.")
            .MustAsync(CheckIfOutfitExist)
            .WithMessage("There is no outfit with the given Id.");

        When(o => o.Name != null, () =>
        {
            RuleFor(o => o.Name)
                 .NotEmpty()
                 .WithMessage("Name must have a value.")
                 .Length(4, 30)
                 .WithMessage("Name must not have less than 4 and more than 30 characters.");
        });
    }

    private async Task<bool> CheckIfOutfitExist(Guid id, CancellationToken cancellationToken)
    {
        var outfit = await _outfitRepository.GetByIdAsync(id);
        return outfit != null;
    }

    private async Task<bool> CheckIfGuidValue<T>(T value, CancellationToken cancellationToken)
    {
        return await Task.FromResult(typeof(Guid) == value.GetType());
    }
}