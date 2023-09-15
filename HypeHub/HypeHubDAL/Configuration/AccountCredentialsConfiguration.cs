using HypeHubDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeHubDAL.Configuration;

public class AccountCredentialsConfiguration : IEntityTypeConfiguration<AccountCredentials>
{
    public void Configure(EntityTypeBuilder<AccountCredentials> builder)
    {
        builder.HasKey(ac => ac.Id);

        builder.Property(ac => ac.AccountId)
            .IsRequired();

        builder.HasIndex(ac => ac.Email)
            .IsUnique();

        builder.Property(ac => ac.Password)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(ac => ac.Email)
            .IsRequired()
            .HasMaxLength(255);
    }
}
