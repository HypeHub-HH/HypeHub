using HypeHubAPI.Configurations;
using FluentValidation;
using System.Reflection;
using HypeHubLogic.Services.Interfaces;
using HypeHubLogic.Services;
using HypeHubLogic.Validators;
using Serilog;
using Serilog.Ui.Web;

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
builder.Host.AddSerilog();
builder.Services.AddUISerilog(builder.Configuration);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:3000")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();

app.UseCors();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseSerilogUi();


app.MapControllers();
app.AddGlobalExeptionsHandler();
try
{
    Log.Information("Starting up application.");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application start-up failed!");
}