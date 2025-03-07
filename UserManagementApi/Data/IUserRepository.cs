using UserManagementApi.Models;

namespace UserManagementApi.Data;

public interface IUserRepository
{
    Task<User?> GetUserAsync(int id);
    Task<User> CreateUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
}
