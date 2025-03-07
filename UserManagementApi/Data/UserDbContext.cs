using Microsoft.EntityFrameworkCore;
using UserManagementApi.Models;

namespace UserManagementApi.Data;

public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}

