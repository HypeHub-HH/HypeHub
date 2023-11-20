using HypeHubLogic.Services;
using Serilog;
using Serilog.Sinks.MSSqlServer;

namespace HypeHubAPI.Configurations;
public static class HostBuilderExtension
{
    public static void AddSerilog(this IHostBuilder hostBuilder, IConfiguration configuration)
    {
        hostBuilder.UseSerilog((context, services, config) =>
        {
            var hypeHubSerielogDatabaseKey = AzureKeyVaultService.GetSecretAsync(configuration, "HypeHubSerielogDatabaseKey").GetAwaiter().GetResult();
            var sinkOpts = new MSSqlServerSinkOptions
            {
                TableName = "Logs",
                SchemaName = "EventLogs",
                AutoCreateSqlDatabase = false,
                AutoCreateSqlTable = true
            };
            var columnOpts = new ColumnOptions();

            config
            .WriteTo.MSSqlServer(
            connectionString: hypeHubSerielogDatabaseKey,
            sinkOptions: sinkOpts,
            columnOptions: columnOpts)
            .MinimumLevel.Warning();
        });
    }
}
