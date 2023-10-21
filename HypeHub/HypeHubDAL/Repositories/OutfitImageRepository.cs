using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;
public class OutfitImageRepository : BaseImageRepository<OutfitImage>, IOutfitImageRepository
{
    public OutfitImageRepository(HypeHubContext dbContext) : base(dbContext) { }
    public async Task<List<OutfitImage>> GetAllOutfitImagesAsync(Guid outfitId)
    {
        return await _dbContext.OutfitImages.Where(outfitImages => outfitImages.OutfitId == outfitId)
                                            .ToListAsync();
    }
}

