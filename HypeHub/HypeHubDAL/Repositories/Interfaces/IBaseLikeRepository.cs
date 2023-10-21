namespace HypeHubDAL.Repositories.Interfaces;
public interface IBaseLikeRepository<T> where T : class
{
    Task<T> AddAsync(T entity);
    Task DeleteAsync(T entity);
}