using HypeHubDAL.DbContexts;
using HypeHubDAL.Repositories.Interfaces;

namespace HypeHubDAL.Repositories;
public class BaseImageRepository<T> : IBaseImageRepository<T> where T : class
{
    protected readonly HypeHubContext _dbContext;
    public BaseImageRepository(HypeHubContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }
    public async Task<T> AddAsync(T entity)
    {
        var result = await _dbContext.Set<T>().AddAsync(entity);
        var addedEntity = result.Entity;
        await _dbContext.SaveChangesAsync();
        return addedEntity;
    }
    public async Task DeleteAsync(T entity)
    {
        await Task.Run(() =>
        {
            _dbContext.Set<T>().Remove(entity);
        });
        await _dbContext.SaveChangesAsync();
    }
}
