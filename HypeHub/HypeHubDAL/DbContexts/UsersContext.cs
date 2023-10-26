using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HypeHubDAL.Models;
using HypeHubDAL.Seeder;
using System.Data;

namespace HypeHubDAL.DbContexts;
public class UsersContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
{
    public UsersContext(DbContextOptions<UsersContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var seeder = new SeederGenerator();

        var accounts = seeder.CreateRandomAccountsForIdentity();
        modelBuilder.Entity<ApplicationUser>().HasData(accounts);

        var roles = seeder.CreateRolesForIdentity();
        modelBuilder.Entity<IdentityRole>().HasData(roles);

        var rolesForAccounts = seeder.CreateAndAssignAccountRolesForIdentity();
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(rolesForAccounts);

        base.OnModelCreating(modelBuilder);
    }
}
