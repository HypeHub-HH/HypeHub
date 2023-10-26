using HypeHubDAL.Models.Relations;

namespace HypeHubDAL.Repositories.Interfaces;
public interface IOutfitItemRepository
{
    Task<OutfitItem> AddAsync(OutfitItem outfitItem);
    Task DeleteAsync(OutfitItem outfitItem);
}