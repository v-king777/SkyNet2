using SkyNet2.Data.Repository;

namespace SkyNet2.Data.UoW;

public interface IUnitOfWork : IDisposable
{
    int SaveChanges(bool ensureAutoHistory = false);

    IRepository<TEntity> GetRepository<TEntity>(bool hasCustomRepository = true) where TEntity : class;
}