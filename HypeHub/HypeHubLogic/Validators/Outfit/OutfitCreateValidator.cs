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
    }

    private async Task<bool> CheckIfAccountExist(Guid id, CancellationToken cancellationToken) =>
        await _accountRepository.GetByIdAsync(id) != null;
}