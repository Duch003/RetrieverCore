using RetrieverCore.Common.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Interfaces
{
    public interface IGenericDatabaseRepository<T> where T : EntityBase, new()
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetBySetIdAsync(Guid setId, bool deleted = false);
        Task<int> AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(int id);
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> conditions, params Expression<Func<T, object>>[] includes);
        Task<T> SingleAsync(Expression<Func<T, bool>> conditions, params Expression<Func<T, object>>[] includes);
    }
}