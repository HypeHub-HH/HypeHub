using HypeHubAPI.Configurations;
using FluentValidation;
using System.Reflection;
using HypeHubLogic.Services.Interfaces;
using HypeHubLogic.Services;
using Microsoft.AspNetCore.Authorization;
using HypeHubAPI;
using HypeHubLogic.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGenWithJwt();
builder.Services.AddDbContexts(builder.Configuration);
builder.Services.AddRepositories();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IOwnershipValidator, OwnershipValidator>();
builder.Services.AddAutoMapper(Assembly.Load("HypeHubLogic"));
builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.Load("HypeHubLogic")));
builder.Services.AddValidatorsFromAssembly(Assembly.Load("HypeHubLogic"));
builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddIdentity();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.AddGlobalExeptionsHandler();
app.Run();