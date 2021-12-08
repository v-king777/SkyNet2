namespace SkyNet2.Data.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T Get(int id)
    {
        throw new NotImplementedException();
    }

    public void Create(T item)
    {
        throw new NotImplementedException();
    }

    public void Update(T item)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}