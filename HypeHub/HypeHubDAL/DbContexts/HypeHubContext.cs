using HypeHubDAL.Generators;
using HypeHubDAL.Models;
using HypeHubDAL.Models.Relations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HypeHubDAL.DbContexts
{
    public class HypeHubContext : DbContext
    {
        public HypeHubContext(DbContextOptions<HypeHubContext> options) : base(options) { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountCredentials> AccountCredentials { get; set; }
        public DbSet<Outfit> Outfits { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OutfitImage> OutfitImages { get; set; }
        public DbSet<ItemImage> ItemsImages { get; set; }
        public DbSet<AccountOutfitLike> AccountOutfitLikes { get; set; }
        public DbSet<AccountItemLike> AccountItemLikes { get; set; }
        public DbSet<OutfitItem> OutfitItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var fakeGenerator = new FakeDataGenerator();
            var numberOfAccounts = 2;
            var numberOfItemsPerWardrobe = 1;
            var numberOfItemsPerOutfit = 2;
            var fakeData = fakeGenerator.GenerateFakeData(numberOfAccounts, numberOfItemsPerWardrobe, numberOfItemsPerOutfit);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Account>().HasData(fakeData.Accounts);
            modelBuilder.Entity<AccountCredentials>().HasData(fakeData.AccountsCredentials);
            modelBuilder.Entity<Outfit>().HasData(fakeData.Outfits);
            modelBuilder.Entity<Item>().HasData(fakeData.Items);
            modelBuilder.Entity<OutfitImage>().HasData(fakeData.OutfitImages);
            modelBuilder.Entity<ItemImage>().HasData(fakeData.ItemImages);
        }
    }
}
