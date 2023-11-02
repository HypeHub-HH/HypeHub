using HypeHubDAL.DbContexts;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;
public class AccountItemLikeRepository : BaseLikeRepository<AccountItemLike>, IAccountItemLikeRepository
{
    public AccountItemLikeRepository(HypeHubContext dbContext) : base(dbContext) { }
    public async Task<AccountItemLike?> GetAsyncByAccountAndItemId(AccountItemLike accountItemLike)
    {
        return await _dbContext.AccountItemLikes.Where(ail =>
            ail.AccountId == accountItemLike.AccountId &&
            ail.ItemId == accountItemLike.ItemId
        ).SingleOrDefaultAsync();
    }
    public async Task<List<AccountItemLike>> GetItemLikesAsync(Guid itemId)
    {
        return await _dbContext.AccountItemLikes.Where(ail =>
            ail.ItemId == itemId)
            .ToListAsync();
    }
}
