using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;

public class AccountRepository : BaseRepository<Account>, IAccountRepository
{
    public AccountRepository(HypeHubContext dbContext) : base(dbContext)
    { }

    public async Task<bool> CheckIfUsernameAlreadyExistAsync(string username)
    {
        return await _dbContext.Accounts.AnyAsync(a => a.Username.Equals(username));
    }

    public async Task<Account> GetAccountWithOutfits(Guid id)
    {
        return await _dbContext.Accounts.Include(a => a.Outfits).ThenInclude(o => o.Images).FirstOrDefaultAsync(a => a.Id == id);
    }
}
