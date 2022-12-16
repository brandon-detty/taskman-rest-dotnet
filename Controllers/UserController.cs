using Microsoft.AspNetCore.Mvc;

using taskman_rest_dotnet.Models;
using taskman_rest_dotnet.Services;

namespace taskman_rest_dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<ICollection<User>> GetAll() => UserService.GetAll().Values;
}
