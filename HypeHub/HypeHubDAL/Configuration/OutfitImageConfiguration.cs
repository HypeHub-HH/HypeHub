using HypeHubDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeHubDAL.Configuration;

public class OutfitImageConfiguration : IEntityTypeConfiguration<OutfitImage>
{
    public void Configure(EntityTypeBuilder<OutfitImage> builder)
    {
        builder.HasKey(oi => oi.Id);

        builder.Property(oi => oi.OutfitId)
            .IsRequired();
    }
}
