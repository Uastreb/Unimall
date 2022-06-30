using Core.Interfaces.Data.BaseRepository;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq.Expressions;

namespace Data.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DataContext _dbContext;

        protected readonly IDbTransaction _transaction;
        protected readonly IDbConnection _connection;

        public BaseRepository(DataContext dbContext, IDbTransaction transaction, IDbConnection connection)
        {
            _dbContext = dbContext;
            _transaction = transaction;
            _connection = connection;
        }


        public virtual IQueryable<T> Entities => _dbContext.Set<T>();

        public virtual async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public virtual Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);

            return Task.CompletedTask;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext
                .Set<T>()
                .ToArrayAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetPagedReponseAsync(int pageNumber, int pageSize)
        {
            return await _dbContext
                .Set<T>()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToArrayAsync();
        }

        public virtual Task UpdateAsync(T entity)
        {
            _dbContext.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;

            return Task.CompletedTask;
        }

        public async Task<IEnumerable<R>> GetByPredicateAsync<R>(Expression<Func<T, R>> selector, Expression<Func<T, bool>> predicate)
        {
            var results = await _dbContext.Set<T>().Where(predicate).Select(selector).ToListAsync();

            return results;
        }

        public async Task<IEnumerable<T>> GetByPredicateAsync(Expression<Func<T, bool>> predicate)
        {
            var results = await _dbContext.Set<T>().Where(predicate).ToListAsync();

            return results;
        }
    }
}
