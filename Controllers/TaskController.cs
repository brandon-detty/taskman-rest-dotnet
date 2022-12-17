using Microsoft.AspNetCore.Mvc;

namespace taskman_rest_dotnet.Controllers;

[Route("[controller]")]
public class TaskController : BaseController<Models.Task>
{
    public TaskController(ILogger<TaskController> logger)
        : base(logger, Services.TaskService.Instance) { }
}
