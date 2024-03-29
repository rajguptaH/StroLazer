using KeplerCrud.Connection;
using KeplerCrud.Repository;
using WebApiCrud.Library.Connection;
using WebApiCrud.Library.Connection.Interface;
using WebApiCrud.Models;
using WebApiCrud.Utility.Data.Service;
using WebApiCrud.Utility.Data.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IConnectionBuilder, ConnectionBuilder>();

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
