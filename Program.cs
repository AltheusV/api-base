using System.Reflection;
using api_base.Data;
using api_base.Settings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var assembly = Assembly.GetExecutingAssembly();

var repositories = assembly.GetRepositories();
foreach (var repository in repositories)
{
    builder.Services.AddScoped(repository.First(), repository.Last());
}

var services = assembly.GetServices();
foreach (var service in services)
{
    builder.Services.AddScoped(service.First(), service.Last());
}

var handlers = assembly.GetHandlers();

foreach (var handler in handlers)
{
    builder.Services.AddScoped(handler);
}

builder.Services.AddDbContext<Context>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Context"));
    options.UseSnakeCaseNamingConvention();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
