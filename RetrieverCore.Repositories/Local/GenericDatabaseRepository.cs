using Microsoft.EntityFrameworkCore;
using RetrieverCore.Common.Models.Base;
using RetrieverCore.LocalDatabase;
using RetrieverCore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Local
{
    public class GenericDatabaseRepository<T> : IGenericDatabaseRepository<T> where T : EntityBase, new()
    {
        private readonly LocalDatabaseContext _context;

        public GenericDatabaseRepository(LocalDatabaseContext context)
        {
            _context = context;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>()
                .FirstOrDefaultAsync(x => x.ID == id);
        }

        public virtual async Task<IEnumerable<T>> GetBySetIdAsync(Guid setId, bool deleted = false)
        {
            return await _context.Set<T>()
                .Where(x => x.SetID == setId && x.Deleted == deleted)
                .ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> conditions, params Expression<Func<T, object>>[] includes)
        {
            var set = _context.Set<T>().AsQueryable();
            foreach(var include in includes)
            {
                set = set.Include(include);
            }

            return await set.AsNoTracking()
                .Where(conditions)
                .ToListAsync();
        }

        public virtual async Task<T> SingleAsync(Expression<Func<T, bool>> conditions, params Expression<Func<T, object>>[] includes)
        {
            var set = _context.Set<T>().AsQueryable();
            foreach (var include in includes)
            {
                set = set.Include(include);
            }

            return await set.AsNoTracking()
                .FirstOrDefaultAsync(conditions);
        }

        public virtual async Task<int> AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            return await _context.SaveChangesAsync();
        }

        public virtual async Task<int> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            return await _context.SaveChangesAsync();
        }

        public virtual async Task<int> DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstAsync(x => x.ID == id);
            entity.Deleted = true;
            
            return await _context.SaveChangesAsync();
        }
    }
}
