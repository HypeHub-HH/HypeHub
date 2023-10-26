using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;
public interface IAccountRepository : IBaseRepository<Account>
{
    Task<bool> CheckIfUsernameAlreadyExistAsync(string username);
    Task<Account?> GetAccountWithOutfitsAsync(Guid accountId);
    Task<Account?> GetAccountWithItemsAsync(Guid accountId);
    Task<List<Account>> GetSearchedAccountsAsync(string searchedString);
    Task<List<Guid>> GetAllOutfitsAndItemsIdsForAccount(Guid accountId);
}
