using Microsoft.AspNetCore.Mvc;

using taskman_rest_dotnet.Models;
using taskman_rest_dotnet.Services;

namespace taskman_rest_dotnet.Controllers;

[ApiController]
public class BaseController<T> : ControllerBase where T : BaseModel
{
    protected readonly ILogger<BaseController<T>> _logger;

    protected ICachedService repo;

    public BaseController(ILogger<BaseController<T>> logger, ICachedService repo)
    {
        _logger = logger;
        this.repo = repo;
    }

    [HttpGet]
    public ActionResult<Dictionary<long, T>> GetAll() => repo.GetAll<T>();

    [HttpGet("{id}")]
    public ActionResult<BaseModel> Get(long id)
    {
        var res = repo.Get<T>(id);

        if (res == null)
        {
            return NotFound();
        }

        return res;
    }
}
