using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;
public class ItemRepository : BaseRepository<Item>, IItemRepository
{
    public ItemRepository(HypeHubContext dbContext) : base(dbContext) { }
    public async Task<Item?> GetItemWithLikesAndImagesAsync(Guid itemId)
    {
        return await _dbContext.Items
            .Include(i => i.Likes)
            .Include(i => i.Images)
            .Include(i => i.Account)
            .SingleOrDefaultAsync(i => itemId == i.Id);
    }
}
