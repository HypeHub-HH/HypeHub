using Serilog;

namespace HypeHubAPI.Configurations;
public static class HostBuilderExtension
{
    public static void AddSerilog(this IHostBuilder hostBuilder, IConfiguration configuration)
    {
        hostBuilder.UseSerilog((hostingContext, loggerConfig) =>
        {
            var hypeHubSerielogDatabaseKey = ServiceCollectionExtension.GetSecretAsync(configuration, "HypeHubSerielogDatabaseKey").GetAwaiter().GetResult();
            loggerConfig.WriteTo.MSSqlServer(
            connectionString: hypeHubSerielogDatabaseKey,
            tableName: "Logs",
            autoCreateSqlTable: true).MinimumLevel.Error();
        });
    }
}
