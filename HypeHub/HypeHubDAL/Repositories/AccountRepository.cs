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

    public async Task<Account?> GetAccountWithOutfitsAsync(Guid accountId)
    {
        return await _dbContext.Accounts
            .Include(a => a.Outfits)
            .ThenInclude(o => o.Images)
            .Include(a => a.Outfits)
            .ThenInclude(o => o.Likes)
            .SingleOrDefaultAsync(a => a.Id == accountId);
    }
    public async Task<List<Account>> GetSearchedAccountsAsync(string searchedString)
    {
        return await _dbContext.Accounts.Where(a => a.Username.StartsWith(searchedString)).ToListAsync();
    }
}
