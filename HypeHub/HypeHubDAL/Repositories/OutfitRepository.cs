using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;

public class OutfitRepository : BaseRepository<Outfit>, IOutfitRepository
{
    public OutfitRepository(HypeHubContext dbContext) : base(dbContext) { }
    public async Task<Outfit?> GetOutfitWithAccountAndItemsAndLikesAsync(Guid outfitId)
    {
        return await _dbContext.Outfits
            .Include(o => o.Account)
            .Include(o => o.Likes)
            .Include(o => o.Images)
            .Include(o => o.Items)
            .ThenInclude(i => i.Images)
            .Include(o => o.Items)
            .ThenInclude(i => i.Likes)
            .SingleOrDefaultAsync(o => o.Id == outfitId);
    }
    public async Task<PagedList<Outfit>> GetLatesOutfitsWithAccountsAndImagesAndLikesAsync(int page, int pageSize)
    {
        var outfits = await _dbContext.Outfits
            .Include(o => o.Account)
            .Include(o => o.Images)
            .Include(o => o.Likes)
            .OrderByDescending(o => o.CreationDate)
            .ToListAsync();
        return PagedList<Outfit>.ToPagedList(outfits, page, pageSize);
    }
}