using HypeHubDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeHubDAL.Configuration;

public class ItemImageConfiguration : IEntityTypeConfiguration<ItemImage>
{
    public void Configure(EntityTypeBuilder<ItemImage> builder)
    {
        builder.HasKey(ii => ii.Id);

        builder.Property(ii => ii.ItemId)
            .IsRequired();
    }
}
