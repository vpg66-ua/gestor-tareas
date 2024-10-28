using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using GestorTareas.Services;
using GestorTareas.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Authentication service
builder.Services.AddControllers();
builder.Services.AddScoped<AuthService>();

var configuration = new ConfigurationBuilder()
    .AddJsonFile("secrets.json")
    .Build();

var connectionString = configuration["DefaultConfiguration"];

builder.Services.AddDbContext<ApplicationDbContext>(
    dbContextOptions => dbContextOptions.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 39))));

            

var app = builder.Build();

// Configure the HTTP request pipeline.
// It's important to see the different HTTP methods that are available in the Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
