using Microsoft.AspNetCore.Mvc;

using taskman_rest_dotnet.Models;

namespace taskman_rest_dotnet.Controllers;

[Route("[controller]")]
public class UserController : BaseController<User>
{
    public UserController(ILogger<UserController> logger)
        : base(logger, Services.UserService.Instance) { }
}
