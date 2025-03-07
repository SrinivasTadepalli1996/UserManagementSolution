using Microsoft.AspNetCore.Mvc;
using UserManagementApi.Models;
using UserManagementApi.Services.Interfaces;

namespace UserManagementApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(int id)
    {
        var user = await _userService.GetUserAsync(id);
        return user is null ? NotFound() : Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(User user)
    {
        var createdUser = await _userService.CreateUserAsync(user);
        return CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, createdUser);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, User user)
    {
        if (id != user.Id) return BadRequest();

        var updatedUser = await _userService.UpdateUserAsync(user);
        return Ok(updatedUser);
    }
}
