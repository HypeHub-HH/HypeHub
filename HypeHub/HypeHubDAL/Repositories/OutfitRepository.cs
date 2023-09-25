using HypeHubDAL.DbContexts;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;

namespace HypeHubDAL.Repositories;

public class OutfitRepository : BaseRepository<Outfit>, IOutfitRepository
{
    public OutfitRepository(HypeHubContext dbContext) : base(dbContext)
    { }

    public async Task<OutfitImage> AddOutfitImageAsync(Guid outfitId, OutfitImage outfitImage)
    {
        var outfit = await GetByIdAsync(outfitId) ?? throw new NotFoundException("There is no outfit with the given Id.");
        outfit.Images.Add(outfitImage);
        await UpdateAsync(outfit);
        return outfitImage;
    }

    public async Task DeleteOutfitImageAsync(Guid outfitId, OutfitImage outfitImage)
    {
        var outfit = await GetByIdAsync(outfitId) ?? throw new NotFoundException("There is no outfit with the given Id.");
        outfit.Images.Remove(outfitImage);
        await UpdateAsync(outfit);
    }

    public async Task<IReadOnlyList<OutfitImage>> GetAllOutfitImagesAsync(Guid outfitId)
    {
        var outfit = await GetByIdAsync(outfitId) ?? throw new NotFoundException("There is no outfit with the given Id.");
        return outfit.Images;
    }

    public async Task<OutfitImage?> GetOutfitImageByIdAsync(Guid outfitId, Guid outfitImageId)
    {
        var outfit = await GetByIdAsync(outfitId) ?? throw new NotFoundException("There is no outfit with the given Id.");
        return outfit.Images.SingleOrDefault(x => x.Id == outfitImageId);
    }
}
