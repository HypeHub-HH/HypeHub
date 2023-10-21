using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;
public class ItemImageRepository : BaseImageRepository<ItemImage>, IItemImageRepository
{
    public ItemImageRepository(HypeHubContext dbContext) : base(dbContext)
    { }

    public async Task<List<ItemImage>> GetAllItemImagesAsync(Guid itemId)
    {
        return await _dbContext.ItemsImages.Where(ItemImages => ItemImages.ItemId == itemId)
                                            .ToListAsync();
    }
}