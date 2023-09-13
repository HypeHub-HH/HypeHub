using HypeHubDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;

namespace HypeHubDAL.Configuration;

public class AccountCredentialsConfiguration : IEntityTypeConfiguration<AccountCredentials>
{
    public void Configure(EntityTypeBuilder<AccountCredentials> builder)
    {
        builder.HasKey(e => e.Id);
    }
}
