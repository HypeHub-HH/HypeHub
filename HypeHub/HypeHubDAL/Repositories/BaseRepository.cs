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

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public async Task UpdateAsync(T entity)
    {
        await Task.Run(() =>
        {
            _dbContext.Set<T>().Update(entity);
        });
        await _dbContext.SaveChangesAsync();
    }
}
