using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;

namespace HypeHubDAL.Repositories;

public class AccountRepository : BaseRepository<Account>, IAccountRepository
{
    public AccountRepository(HypeHubContext dbContext) : base(dbContext)
    { }

    public async Task DeleteAsync(Account account)
    {
        await Task.Run(() =>
        {
            _dbContext.Accounts.Remove(account);
        });
        await _dbContext.SaveChangesAsync();
    }
}
