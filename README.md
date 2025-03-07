# User Management API Solution

This repository contains a clean and well-structured Web API built with ASP.NET Core, demonstrating good coding practices, design patterns, SOLID principles, and robust unit tests.

## Steps to run the application

- After cloning the repository, run the following command to install all missing dependencies:

-- dotnet restore

- If you encounter package restore issues, manually install them inside each project:

-- cd UserManagementApi
-- dotnet restore

-- cd ../UserManagementApi.Tests
-- dotnet restore

- After cloning the repository, check if users.db is present inside:

UserManagementApi/users.db

- Run the following commands to generate the database:

-- cd UserManagementApi
-- dotnet ef database update

- If you see an error regarding dotnet-ef, install the Entity Framework CLI:

-- dotnet tool install --global dotnet-ef

- Retry

--dotnet ef database update

-- dotnet ef migrations add InitialCreate
-- dotnet ef database update


- Run the follwoing commands to run the api and see the swagger documentation

-- cd UserManagementApi
-- dotnet run
-- https://localhost:5230/swagger (Open in browser)

- To run all tests inside UserManagementApi.Tests, execute:

-- cd UserManagementSolution
-- dotnet test

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
