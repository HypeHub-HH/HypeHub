using HypeHubDAL.Repositories.Interfaces;
using System.Security.Claims;

namespace HypeHubLogic.Validators;
public class OwnershipValidator : IOwnershipValidator
{
    private readonly IAccountRepository _accountRepository;

    public OwnershipValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }
    public async Task<bool> ValidateOwnership(IEnumerable<Claim> claims, Guid subjectId)
    {
        var userId = Guid.Parse(claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value);
        var ownedOutfitsAndItems = await _accountRepository.GetAllOutfitsAndItemsIdsForAccount(userId);
        return ownedOutfitsAndItems.Exists(a => a == subjectId);
    }
}
