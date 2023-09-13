using HypeHubDAL.Models;

namespace HypeHubDAL.Generators;

public class FakeDataGeneratorModel
{
    public List<Account> Accounts { get; set; }
    public List<AccountCredentials> AccountsCredentials { get; set; }
    public List<Outfit> Outfits { get; set; }
    public List<Item> Items { get; set; }
    public List<OutfitImage> OutfitImages { get; set; }
    public List<ItemImage> ItemImages { get; set; }

    public FakeDataGeneratorModel(List<Account> accounts, List<AccountCredentials> accountsCredentials, List<Outfit> outfits, List<Item> items, List<OutfitImage> outfitImages, List<ItemImage> itemImages)
    {
        Accounts = accounts;
        AccountsCredentials = accountsCredentials;
        Outfits = outfits;
        Items = items;
        OutfitImages = outfitImages;
        ItemImages = itemImages;
    }
}
