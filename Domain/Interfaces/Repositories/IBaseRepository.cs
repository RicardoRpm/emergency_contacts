namespace Domain.Interfaces.Repositories;

public interface IBaseRepository<T> where T : class
{
    IQueryable<T> Entities { get; }
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    int AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
