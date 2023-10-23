using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Models.Types;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubDAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HypeHubTests.RepositoriesTests;

public class OutfitRepositoryTests
{
    private IOutfitRepository _outfitRepository;
    private HypeHubContext _dbContext;
    private static readonly List<Account> _accounts = new()
        {
            new Account(Guid.NewGuid(), "AccountTest1", true, AccountTypes.User, null),
        };
    private static readonly List<Outfit> _outfits = new()
        {
            new Outfit(_accounts.First().Id, "OutfitTest1"),
            new Outfit(_accounts.First().Id, "OutfitTest2"),
            new Outfit(_accounts.First().Id, "OutfitTest3"),
            new Outfit(_accounts.First().Id, "OutfitTest4"),
        };
    private static readonly List<Item> _items = new()
        {
            new Item(_accounts.First().Id, "ItemTest1", CloathingType.Accesories, null, null, null, null, null),
            new Item(_accounts.First().Id, "ItemTest2", CloathingType.Accesories, null, null, null, null, null),
            new Item(_accounts.First().Id, "ItemTest3", CloathingType.Accesories, null, null, null, null, null),
            new Item(_accounts.First().Id, "ItemTest4", CloathingType.Accesories, null, null, null, null, null),
        };
    private static readonly List<OutfitImage> _outfitImages = new()
        {
            new OutfitImage(_outfits[0].Id, "URLTest1"),
            new OutfitImage(_outfits[1].Id, "URLTest2"),
            new OutfitImage(_outfits[2].Id, "URLTest3"),
            new OutfitImage(_outfits[3].Id, "URLTest4"),
        };
    private static readonly List<ItemImage> _itemImages = new()
        {
            new ItemImage(_items[0].Id, "URLTest1"),
            new ItemImage(_items[1].Id, "URLTest2"),
            new ItemImage(_items[2].Id, "URLTest1"),
            new ItemImage(_items[3].Id, "URLTest2"),
        };
    private static readonly List<AccountOutfitLike> _accountOutfitLikes = new()
        {
            new AccountOutfitLike(_outfits[0].Id, _accounts.First().Id),
            new AccountOutfitLike(_outfits[1].Id, _accounts.First().Id),
            new AccountOutfitLike(_outfits[2].Id, _accounts.First().Id),
            new AccountOutfitLike(_outfits[3].Id, _accounts.First().Id),
        };
    private static readonly List<AccountItemLike> _accountItemLikes = new()
        {
            new AccountItemLike(_items[0].Id, _accounts.First().Id),
            new AccountItemLike(_items[1].Id, _accounts.First().Id),
            new AccountItemLike(_items[2].Id, _accounts.First().Id),
            new AccountItemLike(_items[3].Id, _accounts.First().Id),
        };

    [OneTimeSetUp]
    public async Task Setup()
    {
        var options = new DbContextOptionsBuilder<HypeHubContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
        _dbContext = new HypeHubContext(options);
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.Accounts.AddRangeAsync(_accounts);
        await _dbContext.Outfits.AddRangeAsync(_outfits);
        await _dbContext.Items.AddRangeAsync(_items);
        await _dbContext.OutfitImages.AddRangeAsync(_outfitImages);
        await _dbContext.ItemsImages.AddRangeAsync(_itemImages);
        await _dbContext.AccountOutfitLikes.AddRangeAsync(_accountOutfitLikes);
        await _dbContext.AccountItemLikes.AddRangeAsync(_accountItemLikes);
        await _dbContext.SaveChangesAsync();
        _outfitRepository = new OutfitRepository(_dbContext);
    }

    [OneTimeTearDown]
    public async Task TearDown()
    {
        await _dbContext.Database.EnsureDeletedAsync();
        await _dbContext.DisposeAsync();
    }

    [Test]
    public async Task GetOutfitWithAccountAndItemsAndLikesAsync_OutfitExist_ReturnsOutfitWithAccountAndItemsAndLikes()
    {
        // Arrange
        var outfitId = _outfits.First().Id;

        // Act
        var result = await _outfitRepository.GetOutfitWithAccountAndItemsAndLikesAsync(outfitId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result?.Id, Is.EqualTo(outfitId));
            Assert.That(result?.Account, Is.Not.Null);
            foreach (var like in result?.Likes)
            {
                Assert.That(like, Is.Not.Null);
            }
            foreach (var image in result?.Images)
            {
                Assert.That(image, Is.Not.Null);
            }
            foreach (var item in result?.Items)
            {
                Assert.That(item, Is.Not.Null);
                Assert.That(item, Is.Not.Empty);
                foreach (var image in item.Images)
                {
                    Assert.That(image, Is.Not.Null);
                    Assert.That(image, Is.Not.Empty);
                }
                foreach (var like in item.Likes)
                {
                    Assert.That(like, Is.Not.Null);
                    Assert.That(like, Is.Not.Empty);
                }
            }
        });
    }

    [Test]
    public async Task GetOutfitWithAccountAndItemsAndLikesAsync_OutfitDoNotExist_ReturnsNull()
    {
        // Arrange
        var outfitId = Guid.NewGuid();

        // Act
        var result = await _outfitRepository.GetOutfitWithAccountAndItemsAndLikesAsync(outfitId);

        // Assert
        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task GetLatesOutfitsWithAccountsAndImagesAndLikes_OutfitsExist_ReturnsLatestOutfitsWithAccountAndImagesAndLikes()
    {
        // Arrange
        var page1 = 1;
        var count1 = 2;
        var page2 = 2;
        var count2 = 2;

        // Act
        var result1 = await _outfitRepository.GetLatesOutfitsWithAccountsAndImagesAndLikesAsync(page1, count1);
        var result2 = await _outfitRepository.GetLatesOutfitsWithAccountsAndImagesAndLikesAsync(page2, count2);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.Not.Null);
            Assert.That(result1, Is.Not.Empty);
            Assert.That(result1?.Count, Is.EqualTo(count1));
            foreach (var outfit in result1)
            {
                Assert.That(outfit.Account, Is.Not.Null);
                foreach (var like in outfit.Likes)
                {
                    Assert.That(like, Is.Not.Null);
                }
                foreach (var image in outfit.Images)
                {
                    Assert.That(image, Is.Not.Null);
                }
            }
            for (int i = 1; i < result1?.Count; i++)
            {
                Assert.That(result1[i].CreationDate >= result1[i - 1].CreationDate, Is.True);
                Assert.That(result1[i].CreationDate >= result1[i - 1].CreationDate, Is.True);
            }
            Assert.That(result2, Is.Not.Null);
            Assert.That(result2, Is.Not.Empty);
            Assert.That(result2?.Count, Is.EqualTo(count2));
            foreach (var outfit in result2)
            {
                Assert.That(outfit.Account, Is.Not.Null);
                foreach (var like in outfit.Likes)
                {
                    Assert.That(like, Is.Not.Null);
                }
                foreach (var image in outfit.Images)
                {
                    Assert.That(image, Is.Not.Null);
                }
            }
            for (int i = 1; i < result2?.Count; i++)
            {
                Assert.That(result2[i].CreationDate >= result2[i - 1].CreationDate, Is.True);
                Assert.That(result2[i].CreationDate >= result2[i - 1].CreationDate, Is.True);
            }
            Assert.That(result2[0].Id, Is.Not.EqualTo(result1[0].Id));
        });
    }

    [Test]
    public async Task GetLatesOutfitsWithAccountsAndImagesAndLikes_PageAndCountAreZero_ReturnsEmpty()
    {
        // Arrange
        var page = 0;
        var count = 0;

        // Act
        var result = await _outfitRepository.GetLatesOutfitsWithAccountsAndImagesAndLikesAsync(page, count);

        // Assert
        Assert.That(result, Is.Empty);
    }
}