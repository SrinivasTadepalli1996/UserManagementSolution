using Microsoft.EntityFrameworkCore;
using UserManagementApi.Data;
using UserManagementApi.Models;
using UserManagementApi.Services.Interfaces;

namespace UserManagementApi.Services.Implementations;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public Task<User?> GetUserAsync(int id) => _repository.GetUserAsync(id);

    public Task<User> CreateUserAsync(User user) => _repository.CreateUserAsync(user);

    public Task<User> UpdateUserAsync(User user) => _repository.UpdateUserAsync(user);
}

