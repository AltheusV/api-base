using System.Linq.Expressions;
using api_base.Models;

namespace api_base.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task<T?> GetAsync(int id, bool track = false, params Expression<Func<T, object>>[] customIncludes);
        Task<IList<T>> GetAsync(IEnumerable<int> ids, bool track = false, params Expression<Func<T, object>>[] customIncludes);
        Task<IList<T>> GetAsync(bool track = false, params Expression<Func<T, object>>[] customIncludes);
        Task InsertAsync(T entity);
        Task InsertAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        Task SaveChangesAsync();
        Task<bool> ExistsAsync(int id);
    }
}