using UserManagementApi.Models;

public interface IUserRepository
{
    Task<User?> GetUserAsync(int id);
    Task<User> CreateUserAsync(User user);
    Task<User?> UpdateUserAsync(User user); // Fix: Allow nullable return type
}


