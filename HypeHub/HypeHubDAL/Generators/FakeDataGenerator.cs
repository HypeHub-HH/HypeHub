using HypeHubDAL.Models;
using HypeHubDAL.Models.Types;

namespace HypeHubDAL.Generators;

public class FakeDataGenerator
{
    private readonly Random random = new Random();

    public FakeDataGeneratorModel GenerateFakeData(int numberOfAccounts, int numberOfItemsPerAccount, int numberOfOutfitsPerAccount)
    {
        var accounts = CreateRandomAccounts(numberOfAccounts);
        var outfits = CreateTwoOutfitsForEveryAccount(accounts, numberOfOutfitsPerAccount);
        var items = CreateItemsForEveryAccount(accounts, numberOfItemsPerAccount);
        var outfitImages = CreateImageForEveryOutfit(outfits);
        var imageImages = CreateImageForEveryItem(items);

        return new FakeDataGeneratorModel(accounts, outfits, items, outfitImages, imageImages);
    }

    private List<Account> CreateRandomAccounts(int count)
    {
        var accounts = new List<Account>();
        //for (int i = 1; i <= count; i++)
        //{
        //    string username = $"User{i}";
        //    bool isPrivate = i % 2 == 0;
        //    string avatarUrl = isPrivate ? null : $"https://example.com/avatar/user{i}.png";
        //    accounts.Add(new Account("", username, isPrivate, AccountTypes.User, avatarUrl));
        //}
        return accounts;
    }

    private List<Outfit> CreateTwoOutfitsForEveryAccount(List<Account> accounts, int numberOfOutfitsPerAccount)
    {
        var outfits = new List<Outfit>();
        foreach (var account in accounts)
        {
            for (int i = 0; i < numberOfOutfitsPerAccount; i++)
            {
                outfits.Add(new Outfit(account.Id, $"Outfit{random.Next(1000)}"));
            }
        }
        return outfits;
    }

    private List<Item> CreateItemsForEveryAccount(List<Account> accounts, int numberOfItemsPerAccount)
    {
        var items = new List<Item>();
        foreach (var account in accounts)
        {
            for (int i = 1; i <= numberOfItemsPerAccount; i++)
            {
                string itemName = $"Item{i}";
                Guid wardrobeId = Guid.NewGuid();
                CloathingType cloathingType = (CloathingType)(i % Enum.GetValues(typeof(CloathingType)).Length);
                string brand = $"Brand{i}";
                string model = $"Model{i}";
                string colorway = $"Colorway{i}";
                decimal? price = (decimal)(i * 10.0);
                DateTime? purchaseDate = DateTime.UtcNow.AddMonths(-i);
                items.Add(new Item(account.Id, itemName, cloathingType, brand, model, colorway, price, purchaseDate));
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
