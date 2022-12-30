using api_base.Models;

namespace api_base.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task<T?> GetAsync(int id, bool track = false);
        Task<T[]> GetAsync(bool track = false);
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