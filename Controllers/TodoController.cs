using Microsoft.AspNetCore.Mvc;

using taskman_rest_dotnet.Models;

namespace taskman_rest_dotnet.Controllers;

[Route("[controller]")]
public class TodoController : BaseController<Todo>
{
    public TodoController(ILogger<TodoController> logger)
        : base(logger, Services.TodoService.Instance) { }
}
