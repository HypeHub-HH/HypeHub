using HypeHubDAL.Models.Relations;

namespace HypeHubDAL.Repositories.Interfaces;
public interface IAccountOutfitLikeRepository : IBaseLikeRepository<AccountOutfitLike>
{
    Task<AccountOutfitLike?> GetAsyncByAccountAndOutfitId(AccountOutfitLike accountOutfitLike);
    Task<List<AccountOutfitLike>> GetOutfitLikesAsync(Guid outfitId);
}