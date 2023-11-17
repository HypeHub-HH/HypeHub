using Azure.Identity;
using Microsoft.Extensions.Configuration;
using Azure.Security.KeyVault.Secrets;

namespace HypeHubLogic.Services;
public static class AzureKeyVaultService
{
    public static async Task<string> GetSecretAsync(IConfiguration configuration, string secretName)
    {
        var vaultUri = configuration["AzureKeyVault:VaultUri"];
        var client = new SecretClient(new Uri(vaultUri), new DefaultAzureCredential());
        KeyVaultSecret secret = await client.GetSecretAsync(secretName);
        return secret.Value;
    }
}
