using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;
public interface IOutfitImageRepository : IBaseImageRepository<OutfitImage>
{
    Task<List<OutfitImage>> GetAllOutfitImagesAsync(Guid outfitId);
}
