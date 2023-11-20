using HypeHubDAL.DbContexts;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubDAL.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using HypeHubDAL.Models;
using Serilog.Ui.Web;
using Serilog.Ui.MsSqlServerProvider;
using HypeHubLogic.Services.Interfaces;
using HypeHubLogic.Services;
using HypeHubLogic.Validators;
using System.Reflection;

namespace HypeHubAPI.Configurations;
public static class ServiceCollectionExtension
{
    public static void AddCorsPolicy(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
            {
                builder.WithOrigins("https://hypehub.azurewebsites.net")
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });
        });
    }
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<ITokenService, TokenService>();
    }
    public static void AddCustomValidators(this IServiceCollection services)
    {
        services.AddScoped<IOwnershipValidator, OwnershipValidator>();
    }
    public static void AddIdentity(this IServiceCollection services)
    {
        services
            .AddIdentityCore<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<UsersContext>();
    }
    public static void AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        var issuerSigningKey = AzureKeyVaultService.GetSecretAsync(configuration, "IssuerSigningKey").GetAwaiter().GetResult();
        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ClockSkew = TimeSpan.Zero,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    ValidAudience = configuration["JWT:ValidAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(issuerSigningKey)
            ),
                };
            });
    }
    public static void AddDbContexts(this IServiceCollection services, IConfiguration configuration)
    {
        var hypeHubDbKey = AzureKeyVaultService.GetSecretAsync(configuration, "HypeHubEntityDatabaseKey").GetAwaiter().GetResult();
        var usersDbKey = AzureKeyVaultService.GetSecretAsync(configuration, "HypeHubIdentityDatabaseKey").GetAwaiter().GetResult();

        services.AddDbContext<HypeHubContext>(options =>
            options.UseSqlServer(hypeHubDbKey));
        services.AddDbContext<UsersContext>(options =>
            options.UseSqlServer(usersDbKey));
    }
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IItemRepository, ItemRepository>();
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<IOutfitRepository, OutfitRepository>();
        services.AddScoped<IAccountItemLikeRepository, AccountItemLikeRepository>();
        services.AddScoped<IAccountOutfitLikeRepository, AccountOutfitLikeRepository>();
        services.AddScoped<IItemImageRepository, ItemImageRepository>();
        services.AddScoped<IOutfitImageRepository, OutfitImageRepository>();
        services.AddScoped<IOutfitItemRepository, OutfitItemRepository>();
    }
    public static void AddSwaggerGenWithJwt(this IServiceCollection services)
    {
        services.AddSwaggerGen(option =>
        {
            option.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "HypeHubAPI",
                Version = "v1",
                Description = "This is API for HypeHub project. Authenticated and authorized users have acces to all CRUD operations on item, outfits and their accounts.",
                Contact = new OpenApiContact
                {
                    Name = "HypeHub - (Mikołaj Zgórski, Mariusz Woźniak)",
                    Email = "hypehub.hh@gmail.com",
                    Url = new Uri("https://github.com/HypeHub-HH")
                }
            });

            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            option.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

            option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter a valid token",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });
            option.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[]{}
                }
            });
        });
    }
    public static void AddUISerilog(this IServiceCollection services, IConfiguration configuration)
    {
        var hypeHubSerielogDatabaseKey = AzureKeyVaultService.GetSecretAsync(configuration, "HypeHubSerielogDatabaseKey").GetAwaiter().GetResult();
        services.AddSerilogUi(options => options.UseSqlServer(hypeHubSerielogDatabaseKey, "Logs","EventLogs"));
    }

}
