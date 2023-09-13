using HypeHubDAL.Models;
using HypeHubDAL.Models.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeHubDAL.Configuration;

public class OutfitConfiguration : IEntityTypeConfiguration<Outfit>
{
    public void Configure(EntityTypeBuilder<Outfit> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasMany(o => o.Likes).WithOne(aol => aol.Outfit).HasForeignKey(aol => aol.OutfitId);

        builder.HasMany(o => o.Items)
        .WithMany(i => i.Outfits)
        .UsingEntity<OutfitItem>(
            o => o.HasOne<Item>().WithMany().HasForeignKey(oi => oi.ItemId).OnDelete(DeleteBehavior.Restrict),
            i => i.HasOne<Outfit>().WithMany().HasForeignKey(oi => oi.OutfitId).OnDelete(DeleteBehavior.Cascade)
        );

        builder.HasMany(o => o.Images)
        .WithOne(oi => oi.Outfit)
        .HasForeignKey(oi => oi.OutfitId);
    }
}
