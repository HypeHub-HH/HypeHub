using HypeHubDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeHubDAL.Configuration;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasMany(i => i.Likes).WithOne(aol => aol.Item).HasForeignKey(aol => aol.ItemId);

        builder.HasMany(i => i.Images)
        .WithOne(ii => ii.Item)
        .HasForeignKey(ii => ii.ItemId);
    }
}
