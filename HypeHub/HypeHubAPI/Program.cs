using HypeHubAPI.Configurations;
using HypeHubDAL.DbContexts;
using HypeHubDAL.Repositories;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;
using HypeHubLogic.Services.Interfaces;
using HypeHubLogic.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });

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
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});

builder.Services.AddDbContext<HypeHubContext>(options => options.UseSqlServer(builder.Configuration["HypeHubDbKey"]));
builder.Services.AddDbContext<UsersContext>(options => options.UseSqlServer(builder.Configuration["UsersDbKey"]));
builder.Services.AddAutoMapper(Assembly.Load("HypeHubLogic"));
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IOutfitRepository, OutfitRepository>();
builder.Services.AddScoped<IAccountCredentialsRepository, AccountCredentialsRepository>();
builder.Services.AddScoped<IAccountItemLikeRepository, AccountItemLikeRepository>();
builder.Services.AddScoped<IAccountOutfitLikeRepository, AccountOutfitLikeRepository>();
builder.Services.AddScoped<IItemImageRepository, ItemImageRepository>();
builder.Services.AddScoped<IOutfitImageRepository, OutfitImageRepository>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.Load("HypeHubLogic")));
builder.Services.AddValidatorsFromAssembly(Assembly.Load("HypeHubLogic"));

builder.Services
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
            ValidIssuer = builder.Configuration["TokenValidationParameters:ValidIssuer"],
            ValidAudience = builder.Configuration["TokenValidationParameters:ValidAudience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["IssuerSigningKey"])
            ),
        };
    });

builder.Services
    .AddIdentityCore<IdentityUser>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.User.RequireUniqueEmail = true;
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 6;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
    })
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<UsersContext>();

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