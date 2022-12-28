using Microsoft.AspNetCore.Mvc;

using taskman_rest_dotnet.Models;
using taskman_rest_dotnet.Services;

namespace taskman_rest_dotnet.Controllers;

[Route("[controller]")]
public class TodoController : BaseController<Todo>
{
    public TodoController(ILogger<TodoController> logger, ICachedService repo) : base(logger, repo)
    { }
}
