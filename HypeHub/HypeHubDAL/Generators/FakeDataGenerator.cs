using HypeHubDAL.Models;
using HypeHubDAL.Models.Types;

namespace HypeHubDAL.Generators;

public class FakeDataGenerator
{
    private readonly Random random = new Random();

    public FakeDataGeneratorModel GenerateFakeData(int numberOfAccounts, int numberOfItemsPerAccount)
    {
        var accounts = CreateRandomAccounts(numberOfAccounts);
        var accountCredentials = CreateAccountCredentialsForEveryAccount(accounts);
        var wardrobes = CreateWardrobeForEveryAccount(accounts);
        var outfits = CreateTwoOutfitsForEveryAccount(accounts);
        var items = CreateItemsForEveryWardrobe(wardrobes, numberOfItemsPerAccount);
        var outfitImages = CreateImageForEveryOutfit(outfits);
        var imageImages = CreateImageForEveryItem(items);

        return new FakeDataGeneratorModel(accounts, accountCredentials, wardrobes, outfits,items, outfitImages,imageImages);

    }
    private List<Account> CreateRandomAccounts(int count)
    {
        var accounts = new List<Account>();
        for (int i = 1; i <= count; i++)
        {
            string username = $"User{i}";
            bool isPrivate = i % 2 == 0;
            string avatarUrl = isPrivate ? null : $"https://example.com/avatar/user{i}.png";
            accounts.Add(new Account(username, isPrivate, AccountTypes.User, avatarUrl));
        }
        return accounts;
    }
    private List<AccountCredentials> CreateAccountCredentialsForEveryAccount(List<Account> accounts)
    {
        var accountsCredentials = new List<AccountCredentials>();
        foreach (var account in accounts)
        {
            accountsCredentials.Add(new AccountCredentials(account.Id, $"hasłoMasło{random.Next(1000)}", $"{account.Username}@gmail.com"));
        }
        return accountsCredentials;
    }
    private List<Wardrobe> CreateWardrobeForEveryAccount(List<Account> accounts)
    {
        var wardrobes = new List<Wardrobe>();
        foreach (var account in accounts)
        {
            wardrobes.Add(new Wardrobe(account.Id));
        }
        return wardrobes;
    }
    private List<Outfit> CreateTwoOutfitsForEveryAccount(List<Account> accounts)
    {
        var outfits = new List<Outfit>();
        foreach (var account in accounts)
        {
            outfits.Add(new Outfit(account.Id, $"Outfit{random.Next(1000)}"));
            outfits.Add(new Outfit(account.Id, $"Outfit{random.Next(1000)}"));
        }
        return outfits;
    }
    private List<Item> CreateItemsForEveryWardrobe(List<Wardrobe> wardrobes, int numberOfItemsPerWardrobe)
    {
        var items = new List<Item>();
        foreach (var wardrobe in wardrobes)
        {
            for (int i = 1; i <= numberOfItemsPerWardrobe; i++)
            {
                string itemName = $"Item{i}";
                Guid wardrobeId = Guid.NewGuid();
                CloathingType cloathingType = (CloathingType)(i % Enum.GetValues(typeof(CloathingType)).Length);
                string brand = $"Brand{i}";
                string model = $"Model{i}";
                string colorway = $"Colorway{i}";
                decimal? price = (decimal)(i * 10.0); // Assign a price (e.g., $10.0, $20.0, $30.0, ...)
                DateTime? purchaseDate = DateTime.UtcNow.AddMonths(-i); // Purchase date in the past
                items.Add(new Item(itemName, wardrobe.Id, cloathingType, brand, model, colorway, price, purchaseDate));
            }
        }
        return items;
    }
    private List<ItemImage> CreateImageForEveryItem(List<Item> items)
    {
        var images = new List<ItemImage>();
        foreach (var item in items)
        {
            images.Add(new ItemImage(item.Id, "exampleURL"));
        }
        return images;
    }
    private List<OutfitImage> CreateImageForEveryOutfit(List<Outfit> outfits)
    {
        var images = new List<OutfitImage>();
        foreach (var outfit in outfits)
        {
            images.Add(new OutfitImage(outfit.Id, "exampleURL"));
        }
        return images;
    }
}
