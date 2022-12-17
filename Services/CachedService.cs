namespace taskman_rest_dotnet.Services;

using Models;

public abstract class CachedService<T, SELF> : ICachedService<T>
    where T : BaseModel
    where SELF : CachedService<T, SELF>, ICachedService<T>, new()
{
    protected Dictionary<long, T> Cache { get; }

    private static long NextId = 1;

    private static readonly SELF instance;
    public static SELF Instance
    {
        get { return instance; }
    }

    protected CachedService()
    {
        Cache = new Dictionary<long, T>();
    }

    static CachedService()
    {
        instance = new SELF();
    }

    public Dictionary<long, T> GetAll() => Instance.Cache;

    public T? Get(long id) => Instance.Cache.TryGetValue(id, out T? obj) ? obj : null;

    public void Add(T obj)
    {
        obj.Id = NextId++;
        Instance.Cache.Add(obj.Id, obj);
    }

    public void Delete(long id)
    {
        Instance.Cache.Remove(id);
    }

    public void Update(T obj)
    {
        if (!Instance.Cache.ContainsKey(obj.Id))
        {
            Add(obj);
            return;
        }
        Instance.Cache[obj.Id] = obj;
    }
}
