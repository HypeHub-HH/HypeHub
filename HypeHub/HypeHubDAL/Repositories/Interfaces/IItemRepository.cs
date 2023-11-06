using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;
public interface IItemRepository : IBaseRepository<Item>
{
    Task<Item?> GetItemWithLikesAndImagesAsync(Guid itemId);
}
