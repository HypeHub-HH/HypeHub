using HypeHubAPI.Configurations;
using FluentValidation;
using System.Reflection;
using Serilog;
using Serilog.Ui.Web;
using Serilog.Ui.Web.Authorization;
using HypeHubLogic.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGenWithJwt();
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddCustomValidators();
builder.Services.AddIdentity();
builder.Services.AddCorsPolicy();
builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddDbContexts(builder.Configuration);
builder.Services.AddUISerilog(builder.Configuration);
builder.Services.AddAutoMapper(Assembly.Load("HypeHubLogic"));
builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.Load("HypeHubLogic")));
builder.Services.AddValidatorsFromAssembly(Assembly.Load("HypeHubLogic"));

builder.Host.AddSerilog(builder.Configuration);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseSerilogRequestLogging();
app.UseSerilogUi(options =>
{
    var serilogUsername = AzureKeyVaultService.GetSecretAsync(builder.Configuration, "serilogUsername").GetAwaiter().GetResult();
    var serilogPass = AzureKeyVaultService.GetSecretAsync(builder.Configuration, "serilogPass").GetAwaiter().GetResult();
    options.Authorization.Filters = new IUiAuthorizationFilter[]
    {
        new BasicAuthenticationFilter { UserName = serilogUsername, Password = serilogPass }
    };
    options.Authorization.RunAuthorizationFilterOnAppRoutes = true;
});
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