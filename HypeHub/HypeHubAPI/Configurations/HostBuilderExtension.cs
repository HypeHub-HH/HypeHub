using Serilog;

namespace HypeHubAPI.Configurations;
public static class HostBuilderExtension
{
    public static void AddSerilog(this IHostBuilder hostBuilder)
    {
        hostBuilder.UseSerilog((hostingContext, loggerConfig) =>
        {
            loggerConfig.ReadFrom.Configuration(hostingContext.Configuration);
        });
    }
}
