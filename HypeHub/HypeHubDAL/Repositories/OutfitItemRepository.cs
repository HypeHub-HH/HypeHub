using HypeHubDAL.DbContexts;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;

public class OutfitItemRepository : IOutfitItemRepository
{
    protected readonly HypeHubContext _dbContext;
    public OutfitItemRepository(HypeHubContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<OutfitItem> AddAsync(OutfitItem outfitItem)
    {
        var result = await _dbContext.OutfitItems.AddAsync(outfitItem);
        var addedEntity = result.Entity;
        await _dbContext.SaveChangesAsync();
        return addedEntity;
    }

    public async Task DeleteAsync(OutfitItem outfitItem)
    {
        await Task.Run(() =>
        {
            _dbContext.OutfitItems.Remove(outfitItem);
        });
        await _dbContext.SaveChangesAsync();
    }
    public async Task<bool> CheckIfItemIsInAnyOutfitAsync(Guid itemId)
    {
        return await _dbContext.OutfitItems.AnyAsync(oi => oi.ItemId == itemId);
    }
}