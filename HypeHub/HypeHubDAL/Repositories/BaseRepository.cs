using HypeHubDAL.DbContexts;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly HypeHubContext _dbContext;

    public BaseRepository(HypeHubContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
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

    public async Task<T> UpdateAsync(T entity)
    {
        T? updatedEntity = null;
        await Task.Run(() =>
        {
            var result = _dbContext.Set<T>().Update(entity);
            updatedEntity = result.Entity;
        });
        await _dbContext.SaveChangesAsync();
        return updatedEntity;
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
