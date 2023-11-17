using Azure.Identity;
using Microsoft.Extensions.Configuration;
using Azure.Security.KeyVault.Secrets;
using Google.Apis.Auth.OAuth2;

namespace HypeHubLogic.Services;

public static class AzureKeyVaultService
{
    public static async Task<string> GetSecretAsync(IConfiguration configuration, string secretName)
    {
        var vaultUri = configuration["AzureKeyVault:VaultUri"];
        var credentials = new DefaultAzureCredential();
        if(credentials == null)
        {
            var a = Environment.GetEnvironmentVariable("AZURE_CLIENT_ID");
            var b = Environment.GetEnvironmentVariable("AZURE_CLIENT_SECRET");
            var c = Environment.GetEnvironmentVariable("AZURE_TENANT_ID");
            var credentials1 = new ClientSecretCredential(c, a, b);
            var client = new SecretClient(new Uri(vaultUri), credentials1);
            KeyVaultSecret secret = await client.GetSecretAsync(secretName);
            return secret.Value;
        }
        else
        {
            var client = new SecretClient(new Uri(vaultUri), new DefaultAzureCredential());
            KeyVaultSecret secret = await client.GetSecretAsync(secretName);
            return secret.Value;
        }
    }
}
