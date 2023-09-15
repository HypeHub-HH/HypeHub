using HypeHubAPI.Middlewares;
using Microsoft.AspNetCore.Hosting.Builder;

namespace HypeHubAPI.Configurations;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder AddGlobalExeptionsHandler(this IApplicationBuilder applicationBuilder)
        => applicationBuilder.UseMiddleware<GlobalExeptionHandlingMiddleware>();

}
