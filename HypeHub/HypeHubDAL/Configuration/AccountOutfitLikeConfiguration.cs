﻿using HypeHubDAL.Models.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HypeHubDAL.Configuration;

public class AccountOutfitLikeConfiguration : IEntityTypeConfiguration<AccountOutfitLike>
{
    public void Configure(EntityTypeBuilder<AccountOutfitLike> builder)
    {
        builder.HasKey(aol => aol.Id);
    }
}
