namespace taskman_rest_dotnet.Services;

using Models;

public interface ICachedService
{
    Dictionary<long, T> GetAll<T>() where T : BaseModel;

    T? Get<T>(long id) where T : BaseModel;

    void Add<T>(T obj) where T : BaseModel;

    void Delete<T>(long id) where T : BaseModel;

    void Update<T>(T obj) where T : BaseModel;
}
