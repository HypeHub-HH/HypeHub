using FluentValidation;
using HypeHubLogic.DTOs.Outfit;

namespace HypeHubLogic.Validators.Outfit;
public class OutfitUpdateValidator : AbstractValidator<OutfitUpdateDTO>
{
    public OutfitUpdateValidator()
    {
        RuleFor(o => o.Name)
            .NotEmpty()
            .WithMessage("Name must have a value.")
            .Length(4, 30)
            .WithMessage("Name must not have less than 4 and more than 30 characters.");
    }
}
