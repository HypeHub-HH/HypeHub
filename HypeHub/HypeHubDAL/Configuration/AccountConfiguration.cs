using HypeHubDAL.Models;
using HypeHubDAL.Models.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HypeHubDAL.Configuration;
public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(a => a.Id);

        builder.HasIndex(a => a.Username).IsUnique();

        builder.Property(a => a.Username)
            .IsRequired()
            .HasMaxLength(15);

        builder.Property(a => a.IsPrivate)
            .IsRequired()
            .HasConversion(new BoolToZeroOneConverter<int>());

        builder.Property(a => a.AccountTypes)
            .IsRequired()
            .HasConversion(
                v => v.ToString(),
                v => (AccountTypes)Enum.Parse(typeof(AccountTypes), v));

        builder.Property(a => a.AvatarUrl)
            .IsRequired(false)
            .HasMaxLength(400);

        builder.HasMany(a => a.Items)
            .WithOne(i => i.Account)
            .HasForeignKey(i => i.AccountId)
            .IsRequired();

        builder.HasMany(a => a.Outfits)
            .WithOne(o => o.Account)
            .HasForeignKey(o => o.AccountId)
            .IsRequired();
    }
}
