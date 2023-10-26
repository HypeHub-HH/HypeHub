using HypeHubDAL.Models;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Models.Types;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Diagnostics;

namespace HypeHubDAL.Seeder;

public class SeederGenerator
{
    private readonly List<string> usernames = new()
    {
    "Gamer123",
    "GameMaster",
    "ProPlayer",
    "NinjaGamer",
    "NoobSlayer",
    "EpicGamer",
    "TheLegend27",
    "GameAddict",
    "XxGamerxX",
    "SwordMaster",
    "PixelWarrior",
    "GamingGeek",
    "GameOn123",
    "FragMeister",
    "DigitalWarrior",
    "ControllerKing",
    "LevelUp",
    "PwnedYou",
    "QuestHunter",
    "RetroGamer",
    "ArcadeHero",
    "ConsoleChamp",
    "OnlineWarrior",
    "GamerGirl",
    "GameNerd",
    "ZombieSlayer",
    "MageMaster",
    "LootHunter",
    "DungeonCrawler",
    "HighScore",
    "BossBattler",
    "SniperElite",
    "GameGuru",
    "SpeedRunner",
    "eSportsChamp",
    "GameWizard",
    "GamingJunkie",
    "PixelPirate",
    "RPGHero",
    "GameProphet"
    };
    private readonly List<Guid> UserIds = new ()
        {
            new Guid("11111111-1111-1111-1111-111111111111"),
            new Guid("22222222-2222-2222-2222-222222222222"),
            new Guid("33333333-3333-3333-3333-333333333333"),
            new Guid("44444444-4444-4444-4444-444444444444"),
            new Guid("55555555-5555-5555-5555-555555555555"),
            new Guid("66666666-6666-6666-6666-666666666666"),
            new Guid("77777777-7777-7777-7777-777777777777"),
            new Guid("88888888-8888-8888-8888-888888888888"),
            new Guid("99999999-9999-9999-9999-999999999999"),
            new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
            new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
            new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
            new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
            new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
            new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
            new Guid("00000002-0000-0000-0000-000000000000"),
            new Guid("11112222-3333-4444-5555-666677778888"),
            new Guid("11111111-1111-1211-1111-111111111111"),
            new Guid("21111111-1111-1111-1111-111111111111"),
            new Guid("31111111-1111-1111-1111-111111111111"),
            new Guid("41111111-1111-1111-1111-111111111111"),
            new Guid("51111111-1111-1111-1111-111111111111"),
            new Guid("61111111-1111-1111-1111-111111111111"),
            new Guid("71111111-1111-1111-1111-111111111111"),
            new Guid("81111111-1111-1111-1111-111111111111"),
            new Guid("91111111-1111-1111-1111-111111111111"),
            new Guid("12111111-1111-1111-1111-111111111111"),
            new Guid("13111111-1111-1111-1111-111111111111"),
            new Guid("14111111-1111-1111-1111-111111111111"),
            new Guid("15111111-1111-1111-1111-111111111111"),
            new Guid("16111111-1111-1111-1111-111111111111"),
            new Guid("17111111-1111-1111-1111-111111111111"),
            new Guid("18111111-1111-1111-1111-111111111111"),
            new Guid("19111111-1111-1111-1111-111111111111"),
            new Guid("11211111-1111-1111-1111-111111111111"),
            new Guid("11311111-1111-1111-1111-111111111111"),
            new Guid("11411111-1111-1111-1111-111111111111"),
            new Guid("11511111-1111-1111-1111-111111111111"),
            new Guid("11611111-1111-1111-1111-111111111111"),
            new Guid("11611111-1111-1111-2111-111111111111")
        };
    private readonly List<string> colors = new()
        {
            "Red",
            "Blue",
            "Green",
            "Black",
            "White",
            "Yellow",
            "Purple",
            "Pink",
            "Orange",
            "Gray",
            "Teal",
            "Navy",
            "Burgundy",
            "Lavender",
            "Mint",
            "Olive",
            "Mustard",
            "Turquoise",
            "Crimson",
            "Gold",
            "Silver",
            "Bronze",
            "Rose Gold",
            "Indigo",
            "Aqua",
            "Magenta",
            "Sapphire",
            "Emerald",
            "Pearl",
            "Ruby",
            "Cobalt",
            "Plum",
            "Champagne",
            "Lilac",
            "Coral",
            "Amethyst",
            "Tangerine",
            "Slate",
            "Sunset",
        "Peacock"
        };
    private readonly List<string> sneakers = new()
        {
            "Nike Air Max 1",
            "Adidas Stan Smith",
            "Converse Chuck Taylor All Star",
            "Vans Old Skool",
            "Jordan 1 Retro",
            "New Balance 990",
            "Puma Suede Classic",
            "Reebok Classic Leather",
            "Asics Gel-Lyte III",
            "Saucony Shadow 5000",
            "Yeezy Boost 350",
            "Balenciaga Triple S",
            "Air Jordan 11",
            "Nike Air Force 1",
            "Adidas Superstar",
            "Vans Sk8-Hi",
            "Air Jordan 3",
            "Nike Dunk Low",
            "Reebok Question Mid",
            "Puma Cali",
            "Converse Chuck 70",
            "New Balance 990v5",
            "Saucony Jazz Original",
            "Adidas Ultra Boost",
            "Nike React Element 87",
            "Vans Slip-On",
            "Air Jordan 4",
            "Nike SB Dunk",
            "Balenciaga Speed Trainer",
            "Yeezy 700",
            "Reebok Club C",
            "Puma RS-X",
            "Nike Blazer",
            "Asics Gel-Kayano",
            "Adidas NMD",
            "New Balance 574",
            "Jordan 12 Retro",
            "Converse One Star",
            "Vans Era",
            "Nike Cortez",
            "Adidas Yeezy 500"
        };
    private readonly List<string> accessories = new()
        {
            "Scarves",
            "Sunglasses",
            "Belts",
            "Watches",
            "Hats",
            "Gloves",
            "Ties",
            "Earrings",
            "Bracelets",
            "Necklaces",
            "Handbags",
            "Wallets",
            "Cufflinks",
            "Brooches",
            "Hairpins",
            "Socks",
            "Bowties",
            "Beanies",
            "Tights",
            "Headbands",
            "Umbrellas",
            "Tie Clips",
            "Pocket Squares",
            "Belt Buckles",
            "Garters",
            "Cummerbunds",
            "Bandanas",
            "Shawls",
            "Collar Pins",
            "Suspenders",
            "Leg Warmers",
            "Fedoras",
            "Visors",
            "Sarongs",
            "Pashminas",
            "Gaiters",
            "Ascots",
            "Ponchos",
            "Anklets"
        };
    private readonly List<string> torsoClothing = new()
        {
            "T-Shirts",
            "Button-Up Shirts",
            "Sweaters",
            "Hoodies",
            "Tank Tops",
            "Blouses",
            "Polo Shirts",
            "Cardigans",
            "Flannel Shirts",
            "Crop Tops",
            "Peplum Tops",
            "V-Neck Sweaters",
            "Turtlenecks",
            "Henley Shirts",
            "Tunic Tops",
            "Long-Sleeve Tees",
            "Crewneck Sweatshirts",
            "Tube Tops",
            "Wrap Tops",
            "Sleeveless Vests",
            "Sweatshirts",
            "Off-Shoulder Tops",
            "Bodysuits",
            "Bustiers",
            "Cowl Neck Tops",
            "Ponchos",
            "Kimono Tops",
            "Ruffled Blouses",
            "Oversized Shirts",
            "Muscle Tanks",
            "Corset Tops",
            "Camisoles",
            "Tie-Front Shirts",
            "Mock Neck Tops",
            "Raglan Tees",
            "Crop Hoodies",
            "Spaghetti Strap Tops",
            "Fitted Shirts",
            "Empire Waist Tops",
            "Jersey Tops",
            "Graphic Tees"
        };
    private readonly List<string> legClothing = new()
                {
            "Jeans",
            "Leggings",
            "Trousers",
            "Shorts",
            "Skirts",
            "Joggers",
            "Cargo Pants",
            "Chinos",
            "Culottes",
            "Flare Pants",
            "Wide-Leg Pants",
            "Skinny Jeans",
            "Palazzo Pants",
            "Capri Pants",
            "Bermuda Shorts",
            "Pleated Skirts",
            "High-Waisted Shorts",
            "Denim Shorts",
            "Pencil Skirts",
            "Sweatpants",
            "Corduroy Pants",
            "Cargo Shorts",
            "Khaki Pants",
            "A-Line Skirts",
            "Harem Pants",
            "Bootcut Jeans",
            "Yoga Pants",
            "Maxi Skirts",
            "Cropped Pants",
            "Paperbag Waist Pants",
            "Hot Pants",
            "Boyfriend Jeans",
            "Biker Shorts",
            "Jeggings",
            "Straight-Leg Pants",
            "Tulle Skirts",
            "Track Pants",
            "High-Waisted Trousers",
            "Rain Pants",
            "Camo Pants"
        };
    private readonly List<string> popularBrands = new()
        {
            "Nike",
            "Adidas",
            "Puma",
            "Reebok",
            "Converse",
            "Vans",
            "Gucci",
            "Louis Vuitton",
            "Prada",
            "H&M",
            "Zara",
            "Gap",
            "Levi's",
            "Calvin Klein",
            "Tommy Hilfiger",
            "Ralph Lauren",
            "Burberry",
            "Versace",
            "Chanel",
            "Dior",
            "Fendi",
            "Balenciaga",
            "Yves Saint Laurent",
            "Under Armour",
            "New Balance",
            "ASICS",
            "Balmain",
            "Supreme",
            "Off-White",
            "Fila",
            "Tom Ford",
            "Michael Kors",
            "Mango",
            "Columbia",
            "Timberland",
            "The North Face",
            "Patagonia",
            "Guess",
            "Hugo Boss",
            "Diesel"
        };

    private readonly string UserRoleId = "37cadf13-b04f-4467-94a3-34ede27d31cd";
    private readonly string AdminRoleId = "77ec7b31-d322-4f02-93df-4b52dd5c6632";
    private readonly Random random = new();

    #region Identity seeders
    public List<ApplicationUser> CreateRandomAccountsForIdentity()
    {
        var accounts = new List<ApplicationUser>();
        var ph = new PasswordHasher<ApplicationUser>();
        for (int i = 0; i < usernames.Count - 1; i++)
        {
            var username = usernames[i];
            var normalizedUsername = usernames[i].ToUpper();
            var email = $"{username}@gmail.com";
            var normalizedEmail = email.ToUpper();
            var appUser = new ApplicationUser { Id = UserIds[i].ToString(), UserName = username, NormalizedUserName = normalizedUsername, Email = email, EmailConfirmed = false, NormalizedEmail = normalizedEmail };
            var hashedPassword = ph.HashPassword(appUser, "Test1!");
            appUser.PasswordHash = hashedPassword;
            accounts.Add(appUser);
        }
        return accounts;
    }
    public List<IdentityRole> CreateRolesForIdentity()
    {
        var admin = new IdentityRole { Id = AdminRoleId, Name="Admin", NormalizedName="ADMIN" };
        var user = new IdentityRole { Id = UserRoleId, Name = "User", NormalizedName = "USER" };
        return new List<IdentityRole> { admin, user };
    }
    public List<IdentityUserRole<string>> CreateAndAssignAccountRolesForIdentity()
    {
        var rolesForAccounts = new List<IdentityUserRole<string>>();
        for (int i = 0; i < UserIds.Count - 1; i++)
        {
            rolesForAccounts.Add(new IdentityUserRole<string> { RoleId = UserRoleId, UserId = UserIds[i].ToString() });
        }
        return rolesForAccounts;
    }
    #endregion

    #region HypeHub seeders
    public List<Account> CreateAccountsForHypeHub()
    {
        var accounts = new List<Account>();
        for (int i = 0; i < usernames.Count - 1; i++)
        {
            var id = UserIds[i];
            var username = usernames[i];
            var isPrivate = false;
            var avatarURL = $"https://www.w3schools.com/howto/img_avatar.png";
            var account = new Account(id, username, isPrivate, avatarURL);
            accounts.Add(account);
        }
        return accounts;
    }
    public List<Item> CreateItemsForHypeHub(List<Account> accounts)
    {
        var items = new List<Item>();
        var categorizedTypes = new List<List<string>>() { torsoClothing, legClothing, sneakers, accessories };
        
        for (int i = 0;i < accounts.Count - 1; i++)
        {
            var itemsPerAccount = random.Next(10, 30);
            for (int j = 0; j < itemsPerAccount; j++)
            {
                var randomCategory = random.Next(0, 4);
                var name = categorizedTypes[randomCategory][random.Next(categorizedTypes[randomCategory].Count)];
                var accountId = accounts[i].Id;
                var cloathingType = (CloathingType)Enum.ToObject(typeof(CloathingType), randomCategory);
                var brand = popularBrands[random.Next(popularBrands.Count)];
                var model = $"model{i}";
                var colorway = colors[random.Next(colors.Count)];
                var price = random.Next(10, 1500);
                var purchaseDate = DateTime.UtcNow.AddMonths(-j);
                var item = new Item(accountId, name,cloathingType, brand, model, colorway, price, purchaseDate);
                items.Add(item);
            }

        }
        return items;
    }
    public List<ItemImage> CreateImageForEveryItem(List<Item> items)
    {
        var images = new List<ItemImage>();
        foreach (var item in items)
        {
            var randomNumberOfImages = random.Next(0,6);
            for (int i = 0; i < randomNumberOfImages; i++)
            {
                if (item.CloathingType == CloathingType.Torso)
                {
                    images.Add(new ItemImage(item.Id, "https://i.ebayimg.com/images/g/LbIAAOSwaJ9fxE-0/s-l1600.jpg"));
                }
                if (item.CloathingType == CloathingType.Legs)
                {
                    images.Add(new ItemImage(item.Id, "https://static.supersklep.pl/1263418-spodnie-massdnm-craft-jeans-baggy-fit-medium-blue-stone-wash.jpg?w=1920"));
                }
                if (item.CloathingType == CloathingType.Footwear)
                {
                    images.Add(new ItemImage(item.Id, "https://cdn-images.farfetch-contents.com/14/16/47/07/14164707_21073164_600.jpg"));
                }
                else
                {
                    images.Add(new ItemImage(item.Id, "https://www.mastersintime.pl/pictures/rolex-16610lv-po1-submariner-15163687.jpg"));
                }
            }     
        }
        return images;
    }
    public List<Outfit> CreateOutfitsForHypeHub(List<Account> accounts)
    {
        var outfits = new List<Outfit>();
        var numberOfOutfits = random.Next(5);
        foreach (var account in accounts)
        {
            for (int i = 0; i < numberOfOutfits; i++)
            {
                outfits.Add(new Outfit(account.Id, $"Outfit{random.Next(1000)}"));
            }
        }
        return outfits;
    }
    public List<OutfitImage> CreateImageForEveryOutfit(List<Outfit> outfits)
    {
        var images = new List<OutfitImage>();
        var randomNumberOfImages = random.Next(0, 3);
        foreach (var outfit in outfits)
        {
            for (int i = 0; i < randomNumberOfImages; i++)
            {
                images.Add(new OutfitImage(outfit.Id, "https://i.pinimg.com/736x/c5/82/cb/c582cbabbc8bc85481ef6e81195cafe2.jpg"));
            }             
        }
        return images;
    }
    public List<AccountItemLike> CreateLikesForItems(List<Account> accounts, List<Item> items)
    {
        var likes = new List<AccountItemLike>();       
        foreach(var item in items)
        {
            var randomNumberOfLikes = random.Next(0, 10);
            for (int i = 0; i < randomNumberOfLikes; i++)
            {
                var like = new AccountItemLike(item.Id, accounts[i].Id);
                likes.Add(like);    
            }
        }
        return likes;
    }
    public List<AccountOutfitLike> CreateLikesForOutfits(List<Account> accounts, List<Outfit> outfits)
    {
        var likes = new List<AccountOutfitLike>();  
        foreach (var outfit in outfits)
        {
            var randomNumberOfLikes = random.Next(0, 10);
            for (int i = 0; i < randomNumberOfLikes; i++)
            {
                var like = new AccountOutfitLike(outfit.Id, accounts[i].Id);
                likes.Add(like);
            }
        }
        return likes;
    }
    #endregion
}
