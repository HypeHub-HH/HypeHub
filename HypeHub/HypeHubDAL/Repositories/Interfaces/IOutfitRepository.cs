using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;
public interface IOutfitRepository : IBaseRepository<Outfit>
{
    Task<Outfit?> GetOutfitWithAccountAndItemsAndLikesAsync(Guid outfitId);
    Task<PagedList<Outfit>> GetLatesOutfitsWithAccountsAndImagesAndLikesAsync(int page, int count); 
}
