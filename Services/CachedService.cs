namespace taskman_rest_dotnet.Services;

using Models;

public abstract class CachedService<T> where T : BaseModel
{
    private static Dictionary<long, T> Cache { get; }

    private static long NextId = 1;

    static CachedService()
    {
        Cache = new Dictionary<long, T>();
    }

    public static Dictionary<long, T> GetAll() => Cache;

    public static T? Get(long id) => Cache.TryGetValue(id, out T? obj) ? obj : null;

    public static void Add(T obj)
    {
        obj.Id = NextId++;
        Cache.Add(obj.Id, obj);
    }

    public static void Delete(long id)
    {
        Cache.Remove(id);
    }

    public static void Update(T obj)
    {
        if (!Cache.ContainsKey(obj.Id))
        {
            Add(obj);
            return;
        }
        Cache[obj.Id] = obj;
    }
}