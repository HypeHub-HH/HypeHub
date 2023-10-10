using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;

public interface IOutfitRepository : IBaseRepository<Outfit>
{
    Task<Outfit?> GetOutfitWithAccountAndItemsAndLikesAsync(Guid outfitId);
    Task<List<Outfit>> GetLatesOutfitsWithAccountsAndImagesAndLikesAsync(int page, int count); 
}
