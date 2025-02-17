using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Commons
{
    public interface IGenericService<T> where T : class
    {
        IQueryable<T> Entities { get; }
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        int AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
