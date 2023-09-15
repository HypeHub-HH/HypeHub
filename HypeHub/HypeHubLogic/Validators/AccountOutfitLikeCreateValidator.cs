using FluentValidation;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.AccountOutfitLike;

namespace HypeHubLogic.Validators;

public class AccountOutfitLikeCreateValidator : AbstractValidator<AccountOutfitLikeCreateDTO>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IOutfitRepository _outfitRepository;

    public AccountOutfitLikeCreateValidator(IAccountRepository accountRepository, IOutfitRepository outfitRepository)
    {
        _accountRepository = accountRepository;
        _outfitRepository = outfitRepository;

        RuleFor(ail => ail.AccountId)
            .NotEmpty()
            .WithMessage("AccountId must have a value.")
            .MustAsync(BeValidGuid)
            .WithMessage("AccountId must be a valid GUID.")
            .MustAsync(CheckIfAccountExist)
            .WithMessage("There is no account with the given AccountId.");

        RuleFor(ail => ail.OutfitId)
            .NotEmpty()
            .WithMessage("OutfitId must have a value.")
            .MustAsync(BeValidGuid)
            .WithMessage("OutfitId must be a valid GUID.")
            .MustAsync(CheckIfOutfitExist)
            .WithMessage("There is no outfit with the given OutfitId.");
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

    private async Task<bool> BeValidGuid(Guid value, CancellationToken cancellationToken)
    {
        return await Task.FromResult(value != Guid.Empty);
    }
}
