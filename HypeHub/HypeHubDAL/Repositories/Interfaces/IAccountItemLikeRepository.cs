using HypeHubDAL.Models.Relations;

namespace HypeHubDAL.Repositories.Interfaces;

public interface IAccountItemLikeRepository
{
    Task<bool> AddAsync(AccountItemLike accountItemLike);
    Task<bool> DeleteAsync(AccountItemLike accountItemLike);
    Task<AccountItemLike> GetAsyncByAccountAndItemId(AccountItemLike accountItemid);
}
