using Moq;
using Xunit;
using UserManagementApi.Models;
using UserManagementApi.Services;
using UserManagementApi.Data;
using System.Threading.Tasks;
using UserManagementApi.Services.Implementations;
using UserManagementApi.Services.Interfaces;

namespace UserManagementApi.Tests;

public class UserServiceTests
{
    private readonly Mock<IUserRepository> _mockRepository;
    private readonly IUserService _userService;

    public UserServiceTests()
    {
        _mockRepository = new Mock<IUserRepository>();
        _userService = new UserService(_mockRepository.Object);
    }

    [Fact]
    public async Task GetUserAsync_ShouldReturnUser_WhenUserExists()
    {
        // Arrange
        var userId = 1;
        var expectedUser = new User { Id = userId, Name = "John", Email = "john@example.com" };

        _mockRepository.Setup(repo => repo.GetUserAsync(userId))
                       .ReturnsAsync(expectedUser);

        // Act
        var user = await _userService.GetUserAsync(userId);

        // Assert
        Assert.NotNull(user);
        Assert.Equal(expectedUser.Name, user!.Name);
        Assert.Equal(expectedUser.Email, user.Email);
        _mockRepository.Verify(repo => repo.GetUserAsync(userId), Times.Once);
    }

    [Fact]
    public async Task GetUserAsync_ShouldReturnNull_WhenUserDoesNotExist()
    {
        // Arrange
        var userId = 99;

        _mockRepository.Setup(repo => repo.GetUserAsync(userId))
                       .ReturnsAsync((User?)null);

        // Act
        var user = await _userService.GetUserAsync(userId);

        // Assert
        Assert.Null(user);
        _mockRepository.Verify(repo => repo.GetUserAsync(userId), Times.Once);
    }

    [Fact]
    public async Task CreateUserAsync_ShouldReturnCreatedUser()
    {
        // Arrange
        var newUser = new User { Name = "Jane", Email = "jane@example.com" };
        var createdUser = new User { Id = 2, Name = "Jane", Email = "jane@example.com" };

        _mockRepository.Setup(repo => repo.CreateUserAsync(newUser))
                       .ReturnsAsync(createdUser);

        // Act
        var result = await _userService.CreateUserAsync(newUser);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(createdUser.Id, result.Id);
        Assert.Equal("Jane", result.Name);
        Assert.Equal("jane@example.com", result.Email);
        _mockRepository.Verify(repo => repo.CreateUserAsync(newUser), Times.Once);
    }

    [Fact]
    public async Task UpdateUserAsync_ShouldReturnUpdatedUser()
    {
        // Arrange
        var existingUser = new User { Id = 1, Name = "OldName", Email = "old@example.com" };
        var updatedUser = new User { Id = 1, Name = "UpdatedName", Email = "updated@example.com" };

        _mockRepository.Setup(repo => repo.UpdateUserAsync(existingUser))
                       .ReturnsAsync(updatedUser);

        // Act
        var result = await _userService.UpdateUserAsync(existingUser);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(updatedUser.Name, result.Name);
        Assert.Equal(updatedUser.Email, result.Email);
        _mockRepository.Verify(repo => repo.UpdateUserAsync(existingUser), Times.Once);
    }
}

