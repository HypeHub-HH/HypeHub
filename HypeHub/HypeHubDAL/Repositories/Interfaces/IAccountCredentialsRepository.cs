using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;

public interface IAccountCredentialsRepository : IBaseRepository<AccountCredentials>
{
    Task<bool> CheckIfEmailAlreadyExistAsync(string email);
}
