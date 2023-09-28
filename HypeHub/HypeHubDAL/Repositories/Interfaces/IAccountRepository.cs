using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;

public interface IAccountRepository : IBaseRepository<Account>
{
    Task<bool> CheckIfUsernameAlreadyExistAsync(string username);

    Task<Account> GetAccountWithOutfits(Guid id);

    Task<List<Account>> GetSearchedAccounts(string searchedString);
}
