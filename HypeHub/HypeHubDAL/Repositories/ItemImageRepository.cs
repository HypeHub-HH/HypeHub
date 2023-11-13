using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;
public class ItemImageRepository : BaseImageRepository<ItemImage>, IItemImageRepository
{
    public ItemImageRepository(HypeHubContext dbContext) : base(dbContext)
    { }
}