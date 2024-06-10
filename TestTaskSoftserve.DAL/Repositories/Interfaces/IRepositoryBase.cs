using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSoftserve.DAL.Repositories.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> CreateAsync(T entity);

        Task<T?> GetByIdAsync(Guid id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> UpdateAsync(T entity);

        Task<bool> DeleteByIdAsync(Guid id);
    }
}
