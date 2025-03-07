using Microsoft.EntityFrameworkCore;
using UserManagementApi.Models;

namespace UserManagementApi.Data;

public class UserRepository(UserDbContext context) : IUserRepository
{
    public async Task<User?> GetUserAsync(int id) =>
        await context.Users.FindAsync(id);

    public async Task<User> CreateUserAsync(User user)
    {
        context.Users.Add(user);
        await context.SaveChangesAsync();
        return user;
    }

    public async Task<User> UpdateUserAsync(User user)
    {
        context.Users.Update(user);
        await context.SaveChangesAsync();
        return user;
    }
}

