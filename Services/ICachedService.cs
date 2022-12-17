namespace taskman_rest_dotnet.Services;

using Models;

public interface ICachedService<T> where T : BaseModel
{
    Dictionary<long, T> GetAll();

    T? Get(long id);

    void Add(T obj);

    void Delete(long id);

    void Update(T obj);
}
