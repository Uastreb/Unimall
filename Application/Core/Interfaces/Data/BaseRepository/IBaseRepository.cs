using System.Linq.Expressions;

namespace Core.Interfaces.Data.BaseRepository
{
    public interface IBaseRepository<T> : IRepository where T : class
    {
        IQueryable<T> Entities { get; }

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetPagedReponseAsync(int pageNumber, int pageSize);

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<IEnumerable<R>> GetByPredicateAsync<R>(Expression<Func<T, R>> selector, Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> GetByPredicateAsync(Expression<Func<T, bool>> predicate);
    }
}
