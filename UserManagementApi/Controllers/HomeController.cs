using Microsoft.AspNetCore.Mvc;

namespace UserManagementApi.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Content("User Management API is running. Visit /swagger to see API docs.");
}

