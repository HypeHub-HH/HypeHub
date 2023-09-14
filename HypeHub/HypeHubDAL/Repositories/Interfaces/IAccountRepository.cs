using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;

public interface IAccountRepository
{
    Task DeleteAsync(Account account);
    Task<bool> CheckIfUsernameAlreadyExistAsync(string username);
}
