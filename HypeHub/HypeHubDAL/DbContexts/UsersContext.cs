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
        base.OnModelCreating(modelBuilder);
    }
}
