using HypeHubDAL.DbContexts;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;
public class AccountOutfitLikeRepository : BaseLikeRepository<AccountOutfitLike>, IAccountOutfitLikeRepository
{
    public AccountOutfitLikeRepository(HypeHubContext dbContext) : base(dbContext) { }
    public async Task<AccountOutfitLike?> GetAsyncByAccountAndOutfitId(AccountOutfitLike accountOutfitLike)
    {
        return await _dbContext.AccountOutfitLikes.Where(aol =>
            aol.AccountId == accountOutfitLike.AccountId &&
            aol.OutfitId == accountOutfitLike.OutfitId)
            .SingleOrDefaultAsync();
    }
    public async Task<List<AccountOutfitLike>> GetOutfitLikesAsync(Guid outfitId)
    {
        return await _dbContext.AccountOutfitLikes.Where(aol =>
            aol.OutfitId == outfitId)
            .ToListAsync();
    }
}