using Azure.Identity;
using Microsoft.Extensions.Configuration;
using Azure.Security.KeyVault.Secrets;
using Google.Apis.Auth.OAuth2;

namespace HypeHubLogic.Services;

public static class AzureKeyVaultService
{
    public static async Task<string> GetSecretAsync(IConfiguration configuration, string secretName)
    {
        //var vaultUri = configuration["AzureKeyVault:VaultUri"];
        var vaultUri = "https://hypehubkeys.vault.azure.net/";
        var client = new SecretClient(new Uri(vaultUri), new DefaultAzureCredential());
        KeyVaultSecret secret = await client.GetSecretAsync(secretName);
        return secret.Value;
    }
}
