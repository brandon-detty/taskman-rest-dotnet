namespace taskman_rest_dotnet.Services;

using Models;

public class CachedService<T> : ICachedService<T> where T : BaseModel
{
    protected Dictionary<long, T> Cache { get; }

    private static long NextId = 1;

    public CachedService()
    {
        Cache = new Dictionary<long, T>();
    }

    public Dictionary<long, T> GetAll() => Cache;

    public T? Get(long id) => Cache.TryGetValue(id, out T? obj) ? obj : null;

    public void Add(T obj)
    {
        obj.Id = NextId++;
        Cache.Add(obj.Id, obj);
    }

    public void Delete(long id)
    {
        Cache.Remove(id);
    }

    public void Update(T obj)
    {
        if (!Cache.ContainsKey(obj.Id))
        {
            Add(obj);
            return;
        }
        Cache[obj.Id] = obj;
    }
}
