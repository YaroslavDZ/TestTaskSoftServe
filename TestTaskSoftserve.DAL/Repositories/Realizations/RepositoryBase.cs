using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestTaskSoftserve.DAL.Database;
using TestTaskSoftserve.DAL.Repositories.Interfaces;

namespace TestTaskSoftserve.DAL.Repositories.Realizations
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly UniversityDbContext _db;

        public RepositoryBase(UniversityDbContext context)
        {
            _db = context;
        }

        public async Task<T> CreateAsync(T entity)
        {
            _db.Set<T>().Add(entity);

            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            T? instance = await _db.Set<T>().FindAsync(id);

            if (instance is null)
            {
                return false;
            }
            else
            {
                _db.Set<T>().Remove(instance);
            }

            int rowsDeleted = await _db.SaveChangesAsync();

            return rowsDeleted > 0;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await _db.Set<T>()
                .Where(predicate)
                .ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                _db.Set<T>().Update(entity);
                await _db.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error updating entity: {ex.Message}");
            }
        }
    }
}
