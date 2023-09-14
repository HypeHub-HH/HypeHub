using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;

namespace HypeHubDAL.Repositories;

public class AccountCredentialsRepository : BaseRepository<AccountCredentials>, IAccountCredentialsRepository
{
    public AccountCredentialsRepository(HypeHubContext dbContext) : base(dbContext)
    { }
}
