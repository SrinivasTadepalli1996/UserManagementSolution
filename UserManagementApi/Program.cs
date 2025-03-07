using Microsoft.EntityFrameworkCore;
using UserManagementApi.Data;
using UserManagementApi.Services.Interfaces;
using UserManagementApi.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UserDbContext>(opt =>
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

