using SkyNet2.Data.Repository;

namespace SkyNet2.Data.UoW;

public class UnitOfWork : IUnitOfWork
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public int SaveChanges(bool ensureAutoHistory = false)
    {
        throw new NotImplementedException();
    }

    public IRepository<TEntity> GetRepository<TEntity>(bool hasCustomRepository = true) where TEntity : class
    {
        throw new NotImplementedException();
    }
}