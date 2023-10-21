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
            .MustAsync(CheckIfAccountExist)
            .WithMessage("There is no account with the given Id.");

        RuleFor(aol => aol.OutfitId)
            .NotEmpty()
            .WithMessage("OutfitId must have a value.")
            .MustAsync(CheckIfOutfitExist)
            .WithMessage("There is no outfit with the given Id.");
    }
    private async Task<bool> CheckIfAccountExist(Guid id, CancellationToken cancellationToken) =>
        await _accountRepository.GetByIdAsync(id) != null;
    private async Task<bool> CheckIfOutfitExist(Guid id, CancellationToken cancellationToken) =>
        await _outfitRepository.GetByIdAsync(id) != null;
}
