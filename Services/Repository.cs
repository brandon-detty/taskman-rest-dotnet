using Microsoft.EntityFrameworkCore;

using taskman_rest_dotnet.Models;

namespace taskman_rest_dotnet.Services;

public class Repository : ICachedService
{
    protected InMemoryDb db { get; }

    private static long NextId = 1;

    public Repository()
    {
        db = new InMemoryDb();
    }

    public Dictionary<long, T> GetAll<T>() where T : BaseModel
    {
        var ds = db.Set<T>();
        return ds.ToDictionary(o => o.Id);
    }

    public T? Get<T>(long id) where T : BaseModel
    {
        var ds = db.Set<T>();
        return ds.Find(id);
    }

    public void Add<T>(T obj) where T : BaseModel
    {
        var ds = db.Set<T>();
        ds.Add(obj);
        db.SaveChanges();
    }

    public void Delete<T>(long id) where T : BaseModel
    {
        var obj = Get<T>(id);
        if (obj != null)
        {
            var ds = db.Set<T>();
            ds.Remove(obj);
            db.SaveChanges();
        }
    }

    public void Update<T>(T obj) where T : BaseModel
    {
        var ds = db.Set<T>();
        if (!ds.Contains(obj))
        {
            Add(obj);
        }
        else
        {
            ds.Update(obj);
        }
        db.SaveChanges();
    }
}
