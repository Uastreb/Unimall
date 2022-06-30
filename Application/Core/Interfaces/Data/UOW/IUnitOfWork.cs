using Core.Interfaces.Data.BaseRepository;

namespace Core.Interfaces.Data.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<TEntity> Repository<TEntity>()
            where TEntity : class;

        TRepository Repository<TRepository, TEntity>()
            where TRepository : IBaseRepository<TEntity>
            where TEntity : class;

        Task<int> Commit(CancellationToken cancellationToken);

        Task<int> CommitAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);

        Task Rollback();
    }
}
