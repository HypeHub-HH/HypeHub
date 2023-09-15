﻿using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;

namespace HypeHubDAL.Repositories;

public class OutfitRepository : BaseRepository<Outfit>, IOutfitRepository
{
    public OutfitRepository(HypeHubContext dbContext) : base(dbContext)
    { }

}