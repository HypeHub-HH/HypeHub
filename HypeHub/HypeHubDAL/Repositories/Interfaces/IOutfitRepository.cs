using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;

public interface IOutfitRepository : IBaseRepository<Outfit>
{
    Task<IReadOnlyList<OutfitImage>> GetAllOutfitImagesAsync(Guid outfitId);
    Task<OutfitImage?> GetOutfitImageByIdAsync(Guid outfitId, Guid outfitImageId);
    Task<OutfitImage> AddOutfitImageAsync(Guid outfitId, OutfitImage outfitImage);
    Task DeleteOutfitImageAsync(Guid outfitId, OutfitImage outfitImage);
}
