using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;

public class AccountCredentialsRepository : BaseRepository<AccountCredentials>, IAccountCredentialsRepository
{
    public AccountCredentialsRepository(HypeHubContext dbContext) : base(dbContext)
    { }

    public async Task<bool> CheckIfEmailAlreadyExistAsync(string email)
    {
        return await _dbContext.AccountCredentials.AnyAsync(a => a.Email.Equals(email));
    }
}
