# User Management API Solution

This repository contains a clean and well-structured Web API built with ASP.NET Core, demonstrating good coding practices, design patterns, SOLID principles, and robust unit tests.


## Project Overview

The User Management API provides endpoints for:

- Creating new users (`POST`)
- Retrieving user details (`GET`)
- Updating user information (`PUT`)

---

## Technologies & Libraries

- **.NET 8 Web API**
- **Entity Framework Core (SQLite)**
- **Swagger (Swashbuckle)** for API documentation
- **xUnit** and **Moq** for unit testing
- **Dependency Injection** for loose coupling

---

## Project Structure 

- **UserManagementSolution
    ├── UserManagementApi
    └── UserManagementApi.Tests

## UserManagementApi

## Design Patterns Used

- **Repository Pattern**  
  Abstracts database access, separating business logic from data access.

- **Dependency Injection**  
  Ensures loose coupling, making services easier to test and maintain.


##  SOLID Principles Applied

 | Explanation                                    | Usage in Project                                 |
 |------------------------------------------------|--------------------------------------------------|
 | Single Responsibility Principle                | Each class (`Controller`, `Service`, `Repository`) has only one clearly defined responsibility. |
 | Open/Closed Principle                          | Easily extendable services and repositories without modifying existing code. |
 | Liskov Substitution Principle                  | Clearly implemented interfaces (`IUserRepository`, `IUserService`) enabling substitutable implementations. |
 | Interface Segregation Principle                | Specific, targeted interfaces are provided (`IUserRepository`, `IUserService`) instead of general-purpose interfaces. |
 | Dependency Inversion Principle                 | High-level modules (Services, Controllers) depend on abstractions (interfaces) rather than concrete classes. |

- **To run the API:**
- cd UserManagementApi
- dotnet run



##  Test Project Folder Explained Clearly:

- **Service Tests**  
  Validate business logic correctness and data integrity.

- **To run unit tests clearly**
- cd UserManagementSolution
- dotnet test



##  Contact

- ** Srinivas Tadepalli
- email: vasu.tadepalli95@gmail.com
- phone: +353899408943
