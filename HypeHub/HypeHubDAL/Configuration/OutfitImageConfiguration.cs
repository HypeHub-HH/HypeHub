using HypeHubDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Net.Mime.MediaTypeNames;

namespace HypeHubDAL.Configuration;

public class OutfitImageConfiguration : IEntityTypeConfiguration<OutfitImage>
{
    public void Configure(EntityTypeBuilder<OutfitImage> builder)
    {
        builder.HasKey(oi => oi.Id);
    }
}
