using HypeHubDAL.Models.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeHubDAL.Configuration;

public class AccountItemLikeConfiguration : IEntityTypeConfiguration<AccountItemLike>
{
    public void Configure(EntityTypeBuilder<AccountItemLike> builder)
    {
        builder.HasKey(aoi => aoi.Id);

        builder.Property(aoi => aoi.AccountId)
            .IsRequired();

        builder.Property(aoi => aoi.ItemId)
            .IsRequired();
    }
}
