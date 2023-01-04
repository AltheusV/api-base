using System.Linq.Expressions;
using api_base.Data;
using api_base.Models;
using Microsoft.EntityFrameworkCore;

namespace api_base.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly Context db;

        public Repository(Context db)
        {
            this.db = db;
        }

        public virtual void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
        }

        public virtual void Delete(IEnumerable<T> entities)
        {
            db.Set<T>().RemoveRange(entities);
        }

        public virtual async Task<bool> ExistsAsync(int id)
        {
            return await db.Set<T>().AnyAsync(t => t.Id == id);
        }

        public virtual async Task<T?> GetAsync(int id, bool track = false, params Expression<Func<T, object>>[] customIncludes)
        {
            var query = db.Set<T>().AsQueryable();

            if (customIncludes.Any())
            {
                query = customIncludes.Aggregate(query,
                    (current, include) => current.Include(include));
            }

            if (!track)
                query = query.AsNoTracking();

            return await query.Where(t => t.Id == id).SingleOrDefaultAsync();
        }

        public virtual async Task<IList<T>> GetAsync(bool track = false, params Expression<Func<T, object>>[] customIncludes)
        {
            var query = db.Set<T>().AsQueryable();

            if (customIncludes.Any())
            {
                query = customIncludes.Aggregate(query,
                    (current, include) => current.Include(include));
            }

            if (!track)
                query = query.AsNoTracking();

            return await query.ToListAsync();
        }

        public virtual async Task<IList<T>> GetAsync(IEnumerable<int> ids, bool track = false, params Expression<Func<T, object>>[] customIncludes)
        {
            var query = db.Set<T>().Where(e => ids.Contains(e.Id)).AsQueryable();

            if (customIncludes.Any())
            {
                query = customIncludes.Aggregate(query,
                    (current, include) => current.Include(include));
            }

            if (!track)
                query = query.AsNoTracking();

            return await query.ToListAsync();
        }

        public virtual async Task InsertAsync(T entity)
        {
            await db.Set<T>().AddAsync(entity);
        }

        public virtual async Task InsertAsync(IEnumerable<T> entities)
        {
            await db.Set<T>().AddRangeAsync(entities);
        }

        public virtual async Task SaveChangesAsync()
        {
            await db.SaveChangesAsync();
        }

        public virtual void Update(T entity)
        {
            db.Set<T>().Update(entity);
        }

        public virtual void Update(IEnumerable<T> entities)
        {
            db.Set<T>().UpdateRange(entities);
        }
    }
}