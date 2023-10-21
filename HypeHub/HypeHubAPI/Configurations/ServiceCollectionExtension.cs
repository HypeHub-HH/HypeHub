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
                builder.WithOrigins("http://localhost:3000")
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
                Encoding.UTF8.GetBytes(configuration["IssuerSigningKey"])
            ),
                };
            })
            .AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = configuration["Authentication:Google:ClientId"];
                googleOptions.ClientSecret = configuration["Authentication:Google:ClientSecret"];
            });
    }
    public static void AddDbContexts(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HypeHubContext>(options =>
            options.UseSqlServer(configuration["HypeHubDbKey"]));

        services.AddDbContext<UsersContext>(options =>
            options.UseSqlServer(configuration["UsersDbKey"]));
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
        services.AddSerilogUi(options => options.UseSqlServer(configuration["LogsDbKey"], "Logs"));
    }
}
