using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;

public class OutfitRepository : BaseRepository<Outfit>, IOutfitRepository
{
    public OutfitRepository(HypeHubContext dbContext) : base(dbContext)
    { }

    public async Task<Outfit?> GetOutfitWithAccountAndItemsAndLikes(Guid outfitId)
    {
        return await _dbContext.Outfits.Include(o => o.Account)
                                        .Include(o => o.Likes)
                                        .Include(o => o.Images)
                                        .Include(o => o.Items)
                                        .ThenInclude(i => i.Images)
                                        .Include(o => o.Items)
                                        .ThenInclude(i => i.Likes)
                                        .SingleOrDefaultAsync(o => o.Id == outfitId);
    }
}
