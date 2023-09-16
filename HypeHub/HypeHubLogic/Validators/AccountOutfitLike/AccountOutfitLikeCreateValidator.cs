using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.AccountOutfitLike;

namespace HypeHubLogic.Validators.AccountOutfitLike;

public class AccountOutfitLikeCreateValidator : AbstractValidator<AccountOutfitLikeCreateDTO>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IOutfitRepository _outfitRepository;

    public AccountOutfitLikeCreateValidator(IAccountRepository accountRepository, IOutfitRepository outfitRepository)
    {
        _accountRepository = accountRepository;
        _outfitRepository = outfitRepository;

        RuleFor(aol => aol.AccountId)
            .NotEmpty()
            .WithMessage("AccountId must have a value.")
            .MustAsync(CheckIfGuidValue)
            .WithMessage("AccountId must be a valid GUID.")
            .MustAsync(CheckIfAccountExist)
            .WithMessage("There is no account with the given Id.");

        RuleFor(aol => aol.OutfitId)
            .NotEmpty()
            .WithMessage("OutfitId must have a value.")
            .MustAsync(CheckIfGuidValue)
            .WithMessage("OutfitId must be a valid GUID.")
            .MustAsync(CheckIfOutfitExist)
            .WithMessage("There is no outfit with the given Id.");
    }

    private async Task<bool> CheckIfAccountExist(Guid id, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetByIdAsync(id);
        return account != null;
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
