using Core.Interfaces.Data.BaseRepository;
using Core.Interfaces.Data.UOW;
using Data.BaseRepository;
using LazyCache;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Data;

namespace Data.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private bool disposed;
        private Hashtable _repositories;
        private readonly IAppCache _cache;

        private IDbTransaction _transaction;
        private IDbConnection _connection;


        public UnitOfWork(DataContext context, IAppCache cache)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _cache = cache;

            _context.Database.OpenConnection();
            var connection = _context.Database.GetDbConnection();
            var transaction = connection.BeginTransaction();

            _connection = connection;
            _transaction = transaction;
            _context.Database.UseTransaction(transaction);
        }

        public IBaseRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(BaseRepository<>);

                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context, _transaction, _connection);

                _repositories.Add(type, repositoryInstance);
            }

            return (IBaseRepository<TEntity>)_repositories[type];
        }

        public TRepository Repository<TRepository, TEntity>()
            where TRepository : IBaseRepository<TEntity>
            where TEntity : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var repositoryInterface = typeof(TRepository);
            var repositoryTypeName = repositoryInterface.Name;

            if (!_repositories.ContainsKey(repositoryTypeName))
            {
                var repositoryImplementation = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => repositoryInterface.IsAssignableFrom(p) && p.IsClass).First();

                var repositoryInstance = Activator.CreateInstance(repositoryImplementation, _context, _transaction, _connection);

                _repositories.Add(repositoryTypeName, repositoryInstance);
            }

            return (TRepository)_repositories[repositoryTypeName];
        }

        public async Task<int> Commit(CancellationToken cancellationToken)
        {
            var changedEntities = await _context.SaveChangesAsync(cancellationToken);
            _transaction.Commit();

            return changedEntities;
        }

        public async Task<int> CommitAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys)
        {
            var result = await _context.SaveChangesAsync(cancellationToken);
            _transaction.Commit();

            foreach (var cacheKey in cacheKeys)
            {
                _cache.Remove(cacheKey);
            }

            return result;
        }

        public Task Rollback()
        {
            _context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
            _transaction.Rollback();

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose managed resources
                    _context.Dispose();

                    _connection.Close();
                    _transaction.Dispose();
                    _connection.Dispose();
                }
            }
            //dispose unmanaged resources
            disposed = true;
        }
    }
}
