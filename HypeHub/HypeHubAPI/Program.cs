using HypeHubAPI.Configurations;
using HypeHubDAL.DbContexts;
using HypeHubDAL.Repositories;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.CQRS.Item.Queries;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<HypeHubContext>(options =>
{
    options.UseSqlServer(builder.Configuration["HypeHubDbKey"]);
});
builder.Services.AddAutoMapper(Assembly.Load("HypeHubLogic"));
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.Load("HypeHubLogic")));

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

app.AddGlobalExeptionsHandler();

app.Run();
