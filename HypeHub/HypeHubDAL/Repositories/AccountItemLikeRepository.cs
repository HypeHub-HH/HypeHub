using HypeHubDAL.DbContexts;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;

public class AccountItemLikeRepository : IAccountItemLikeRepository
{
    private readonly HypeHubContext _dbContext;

    public AccountItemLikeRepository(HypeHubContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<bool> AddAsync(AccountItemLike accountItemLike)
    {
        await _dbContext.AccountItemLikes.AddAsync(accountItemLike);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<AccountItemLike> GetAsyncByAccountAndItemId(AccountItemLike accountItemid)
    {
        return await Task.Run(() =>
        {
            return _dbContext.AccountItemLikes.Where(ail =>
                ail.AccountId == accountItemid.AccountId &&
                ail.ItemId == accountItemid.ItemId
            ).FirstOrDefaultAsync();
        });
    }

    public async Task<bool> DeleteAsync(AccountItemLike accountItemLike)
    {
        await Task.Run(() =>
        {
            _dbContext.AccountItemLikes.Remove(accountItemLike);
        });
        await _dbContext.SaveChangesAsync();
        return true;
    }
}
