using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;

namespace HypeHubDAL.Repositories;
public class ItemRepository : BaseRepository<Item>, IItemRepository
{
    public ItemRepository(HypeHubContext dbContext) : base(dbContext) { }
}
