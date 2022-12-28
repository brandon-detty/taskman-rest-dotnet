using Microsoft.AspNetCore.Mvc;

using taskman_rest_dotnet.Models;
using taskman_rest_dotnet.Services;

namespace taskman_rest_dotnet.Controllers;

[Route("[controller]")]
public class UserController : BaseController<User>
{
    public UserController(ILogger<UserController> logger, ICachedService repo) : base(logger, repo)
    { }
}
