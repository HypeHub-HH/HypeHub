using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;
public interface IItemImageRepository : IBaseImageRepository<ItemImage>
{
    Task<List<ItemImage>> GetAllItemImagesAsync(Guid imageId);
}
