using HypeHubDAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HypeHubDAL.DbContexts
{
    public class HypeHubContext : DbContext
    {
        public HypeHubContext(DbContextOptions<HypeHubContext> options) : base(options) { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountCredentials> AccountCredentials { get; set; }
        public DbSet<Wardrobe> Wardrobes { get; set; }
        public DbSet<Outfit> Outfits { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OutfitImage> OutfitImages { get; set; }
        public DbSet<ItemImage> ItemsImages { get; set; }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(account =>
            {
                account.HasKey(a => a.Id);

                account.HasOne(a => a.Credentials)
                 .WithOne(c => c.Account)
                 .HasForeignKey<AccountCredentials>(c => c.AccountId);

                account.HasOne(a => a.Wardrobe)
                .WithOne(w => w.Account)
                .HasForeignKey<Wardrobe>(w => w.AccountId);

                account.HasMany(a => a.Outfits)
                .WithOne(o => o.Account)
                .HasForeignKey(o => o.AccountId);

                account.HasMany(a => a.LikedOutfits)
                .WithMany(o => o.Likes);

                account.HasMany(a => a.LikedItems)
                .WithMany(i => i.Likes);
            });

            modelBuilder.Entity<AccountCredentials>(credential =>
            {
                credential.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Wardrobe>(wardrobe =>
            {
                wardrobe.HasKey(e => e.Id);

                wardrobe.HasMany(w => w.Items)
                .WithOne(i => i.Wardrobe)
                .HasForeignKey(i => i.WardrobeId);
            });

            modelBuilder.Entity<Outfit>(outfit =>
            {
                outfit.HasKey(e => e.Id);

                outfit.HasMany(o => o.Items)
                .WithMany(i => i.Outfits);

                outfit.HasMany(o => o.Images)
                .WithOne(oi => oi.Outfit)
                .HasForeignKey(oi => oi.OutfitId);

            });

            modelBuilder.Entity<Item>(item =>
            {
                item.HasKey(e => e.Id);

                item.HasMany(i => i.Images)
                .WithOne(ii => ii.Item)
                .HasForeignKey(ii => ii.ItemId);
            });

            modelBuilder.Entity<OutfitImage>(oImage =>
            {
                oImage.HasKey(oi => oi.Id);
            });

            modelBuilder.Entity<OutfitImage>(iImage =>
            {
                iImage.HasKey(ii => ii.Id);
            });
        }
    }
}
