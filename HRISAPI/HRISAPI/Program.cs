global using HRISAPI.Models;
global using HRISAPI.Contracts;
global using HRISAPI.Controllers;
global using HRISAPI.Infrastracture;
global using HRISAPI.Repositories;

global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton(typeof(IBaseRepository<>), typeof(BaseRepository<>));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
