using Microsoft.AspNetCore.Mvc;

using taskman_rest_dotnet.Services;

namespace taskman_rest_dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    private readonly ILogger<TaskController> _logger;

    public TaskController(ILogger<TaskController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<ICollection<Models.Task>> GetAll() => TaskService.GetAll().Values;
}
