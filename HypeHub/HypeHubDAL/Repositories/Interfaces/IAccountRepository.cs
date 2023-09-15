using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;

public interface IAccountRepository : IBaseRepository<Account>
{
    Task DeleteAsync(Account account);
    Task<bool> CheckIfUsernameAlreadyExistAsync(string username);
}
