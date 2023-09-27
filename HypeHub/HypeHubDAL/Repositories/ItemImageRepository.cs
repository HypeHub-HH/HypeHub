using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubDAL.Repositories;
using Microsoft.EntityFrameworkCore;

public class ItemImageRepository : BaseImageRepository<ItemImage>, IItemImageRepository
{
    public ItemImageRepository(HypeHubContext dbContext) : base(dbContext)
    { }

    public async Task<IReadOnlyList<ItemImage>> GetAllItemImagesAsync(Guid itemId)
    {
        return await _dbContext.ItemsImages.Where(ItemImages => ItemImages.ItemId == itemId)
                                            .ToListAsync();
    }
}