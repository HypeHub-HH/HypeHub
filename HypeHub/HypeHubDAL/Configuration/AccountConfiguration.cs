using HypeHubDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeHubDAL.Configuration;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(a => a.Id);

        builder.HasOne(a => a.Credentials)
            .WithOne(c => c.Account)
            .HasForeignKey<AccountCredentials>(c => c.AccountId);

        builder.HasMany(a => a.Items)
            .WithOne(i => i.Account)
            .HasForeignKey(i => i.AccountId);

        builder.HasMany(a => a.Outfits)
            .WithOne(o => o.Account)
            .HasForeignKey(o => o.AccountId);
    }
}
