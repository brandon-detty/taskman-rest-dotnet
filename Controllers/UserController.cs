using Microsoft.AspNetCore.Mvc;

namespace taskman_rest_dotnet.Controllers;

[Route("[controller]")]
public class UserController : BaseController<Models.User>
{
    public UserController(ILogger<UserController> logger)
        : base(logger, Services.UserService.Instance) { }
}
