using HypeHubDAL.Models;
using HypeHubDAL.Models.Relations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HypeHubDAL.DbContexts;
public class HypeHubContext : DbContext
{
    public HypeHubContext(DbContextOptions<HypeHubContext> options) : base(options) { }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Outfit> Outfits { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<OutfitImage> OutfitImages { get; set; }
    public DbSet<ItemImage> ItemsImages { get; set; }
    public DbSet<AccountOutfitLike> AccountOutfitLikes { get; set; }
    public DbSet<AccountItemLike> AccountItemLikes { get; set; }
    public DbSet<OutfitItem> OutfitItems { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
