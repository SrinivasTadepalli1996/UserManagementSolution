using UserManagementApi.Models;

namespace UserManagementApi.Services.Interfaces;

public interface IUserService
{
    Task<User?> GetUserAsync(int id);
    Task<User> CreateUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
}
