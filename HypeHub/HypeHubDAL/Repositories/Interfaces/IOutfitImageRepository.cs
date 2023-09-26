using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;

public interface IOutfitImageRepository : IBaseImageRepository<OutfitImage>
{
    Task<IReadOnlyList<OutfitImage>> GetAllOutfitImagesAsync(Guid outfitId);
}
