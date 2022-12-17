using Microsoft.AspNetCore.Mvc;

using taskman_rest_dotnet.Models;
using taskman_rest_dotnet.Services;

namespace taskman_rest_dotnet.Controllers;

[ApiController]
public class BaseController<T> : ControllerBase where T : BaseModel
{
    protected readonly ILogger<BaseController<T>> _logger;

    protected ICachedService<T> Service;

    public BaseController(ILogger<BaseController<T>> logger, ICachedService<T> service)
    {
        _logger = logger;
        Service = service;
    }

    [HttpGet]
    // public ActionResult<ICollection<BaseModel>> GetAll() => Service.GetAll().Values;
    public Dictionary<long, T>.ValueCollection GetAll() => Service.GetAll().Values;

    [HttpGet("{id}")]
    public ActionResult<BaseModel> Get(long id)
    {
        var res = Service.Get(id);

        if (res == null)
        {
            return NotFound();
        }

        return res;
    }
}
