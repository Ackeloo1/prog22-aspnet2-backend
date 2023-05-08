using Microsoft.EntityFrameworkCore;
using System;
using WebApi.Contexts;
using WebApi.Repos;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DataContext>(x => x.UseInMemoryDatabase(databaseName: "MemoryDb"));
//builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DataDB")));

builder.Services.AddScoped<ProductRepo>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CategoryRepo>();
builder.Services.AddScoped<AddressRepo>();
builder.Services.AddScoped<AddressService>();








var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
