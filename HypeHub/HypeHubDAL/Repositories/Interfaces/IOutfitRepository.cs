using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;

public interface IOutfitRepository : IBaseRepository<Outfit>
{
    Task<Outfit?> GetOutfitWithAccountAndItemsAndLikes(Guid outfitId);
    Task<List<Outfit>> GetLatesOutfitsWithAccountsAndImagesAndLikes(int page, int count); 
}
