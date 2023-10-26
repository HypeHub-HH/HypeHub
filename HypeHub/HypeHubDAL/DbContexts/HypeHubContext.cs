using HypeHubDAL.Models;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Seeder;
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

        var seeder = new SeederGenerator();

        var accounts = seeder.CreateAccountsForHypeHub();
        modelBuilder.Entity<Account>().HasData(accounts);

        var outfits = seeder.CreateOutfitsForHypeHub(accounts);
        modelBuilder.Entity<Outfit>().HasData(outfits);

        var outfitImages = seeder.CreateImageForEveryOutfit(outfits);
        modelBuilder.Entity<OutfitImage>().HasData(outfitImages);

        var outfitLikes = seeder.CreateLikesForOutfits(accounts, outfits);
        modelBuilder.Entity<AccountOutfitLike>().HasData(outfitLikes);

        var items = seeder.CreateItemsForHypeHub(accounts);
        modelBuilder.Entity<Item>().HasData(items);

        var itemsImages = seeder.CreateImageForEveryItem(items);
        modelBuilder.Entity<ItemImage>().HasData(itemsImages);

        var itemsLikes = seeder.CreateLikesForItems(accounts, items);
        modelBuilder.Entity<AccountItemLike>().HasData(itemsLikes);

        base.OnModelCreating(modelBuilder);
    }
}
