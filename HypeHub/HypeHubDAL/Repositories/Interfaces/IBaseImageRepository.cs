namespace HypeHubDAL.Repositories.Interfaces;
public interface IBaseImageRepository<T> where T : class
{
    Task<T?> GetByIdAsync(Guid id);
    Task<T> AddAsync(T entity);
    Task DeleteAsync(T entity);
}