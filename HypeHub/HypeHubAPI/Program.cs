using HypeHubAPI.Configurations;
using HypeHubDAL.DbContexts;
using HypeHubDAL.Repositories;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<HypeHubContext>(options => options.UseSqlServer(builder.Configuration["HypeHubDbKey"]));
builder.Services.AddAutoMapper(Assembly.Load("HypeHubLogic"));
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IOutfitRepository, OutfitRepository>();
builder.Services.AddScoped<IAccountCredentialsRepository, AccountCredentialsRepository>();
builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.Load("HypeHubLogic")));
builder.Services.AddValidatorsFromAssembly(Assembly.Load("HypeHubLogic"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.AddGlobalExeptionsHandler();
app.Run();