using HypeHubDAL.Models;
using HypeHubDAL.Models.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeHubDAL.Configuration;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.HasKey(i => i.Id);

        builder.Property(i => i.AccountId)
            .IsRequired();

        builder.Property(i => i.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(i => i.CloathingType)
            .IsRequired()
            .HasConversion(
                v => v.ToString(),
                v => (CloathingType)Enum.Parse(typeof(CloathingType), v));

        builder.Property(i => i.Brand)
            .IsRequired(false)
            .HasMaxLength(30);

        builder.Property(i => i.Model)
            .IsRequired(false)
            .HasMaxLength(30);

        builder.Property(i => i.Colorway)
            .IsRequired(false)
            .HasMaxLength(30);

        builder.Property(i => i.Price)
            .IsRequired(false)
            .HasColumnType("decimal(18, 2)");

        builder.Property(i => i.PurchaseDate)
            .IsRequired(false)
            .HasColumnType("datetime2");

        builder.HasMany(i => i.Likes).WithOne(aol => aol.Item)
            .HasForeignKey(aol => aol.ItemId)
            .IsRequired();

        builder.HasMany(i => i.Images)
            .WithOne(ii => ii.Item)
            .HasForeignKey(ii => ii.ItemId)
            .IsRequired();
    }
}
