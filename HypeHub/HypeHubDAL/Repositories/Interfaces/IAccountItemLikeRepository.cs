using HypeHubDAL.Models.Relations;

namespace HypeHubDAL.Repositories.Interfaces;
public interface IAccountItemLikeRepository : IBaseLikeRepository<AccountItemLike>
{
    Task<AccountItemLike?> GetAsyncByAccountAndItemId(AccountItemLike accountItemLike);
}
