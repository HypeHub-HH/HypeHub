using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Models.Types;
using HypeHubDAL.Repositories;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubTests.RepositoriesTests;

[TestFixture]
public class AccountRepositoryTests
{
    private IAccountRepository _accountRepository;
    private HypeHubContext _dbContext;
    private static readonly List<Account> _accounts = new()
        {
            new Account(Guid.NewGuid(), "AccountTest1", true, AccountTypes.User, null),
            new Account(Guid.NewGuid(), "AccountTest2", true, AccountTypes.User, null),
        };
    private static List<Outfit> _outfits = new()
        {
            new Outfit(_accounts.First().Id, "OutfitTest1"),
            new Outfit(_accounts.First().Id, "OutfitTest2"),
        };
    private static List<Item> _items = new()
        {
            new Item(_accounts.First().Id, "ItemTest1", CloathingType.Accesories, null, null, null, null, null),
            new Item(_accounts.First().Id, "ItemTest2", CloathingType.Accesories, null, null, null, null, null),
        };
    private static List<OutfitImage> _outfitImages = new()
        {
            new OutfitImage(_outfits[0].Id, "URLTest1"),
            new OutfitImage(_outfits[1].Id, "URLTest2"),
        };
    private static List<AccountOutfitLike> _accountOutfitLikes = new()
        {
            new AccountOutfitLike(_outfits[0].Id, _accounts.First().Id),
            new AccountOutfitLike(_outfits[1].Id, _accounts.First().Id),
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
        await _dbContext.AccountOutfitLikes.AddRangeAsync(_accountOutfitLikes);
        await _dbContext.SaveChangesAsync();
        _accountRepository = new AccountRepository(_dbContext);
    }

    [OneTimeTearDown]
    public async Task TearDown()
    {
        await _dbContext.Database.EnsureDeletedAsync();
        await _dbContext.DisposeAsync();
    }

    [Test]
    public async Task CheckIfUsernameAlreadyExistAsync_UsernameExists_ReturnsTrue()
    {
        // Arrange
        var searchTerm = "AccountTest1";

        // Act
        var result = await _accountRepository.CheckIfUsernameAlreadyExistAsync(searchTerm);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public async Task CheckIfUsernameAlreadyExistAsync_UsernameDoNotExists_ReturnsFalse()
    {
        // Arrange
        var searchTerm = "Test";

        // Act
        var result = await _accountRepository.CheckIfUsernameAlreadyExistAsync(searchTerm);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public async Task GetAccountWithOutfitsAsync_AccountExist_ReturnsAccountWIthOutfits()
    {
        // Arrange
        var accountId = _accounts.First().Id;

        // Act
        var result = await _accountRepository.GetAccountWithOutfitsAsync(accountId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result?.Id, Is.EqualTo(accountId));
            Assert.That(result?.Outfits, Is.Not.Null);
            Assert.That(result?.Outfits, Is.Not.Empty);
            foreach (var outfit in result?.Outfits)
            {
                Assert.That(outfit.Images, Is.Not.Null);
                Assert.That(outfit.Images, Is.Not.Empty);
                Assert.That(outfit.Likes, Is.Not.Null);
                Assert.That(outfit.Likes, Is.Not.Empty);
            }
        });
    }

    [Test]
    public async Task GetAccountWithOutfitsAsync_AccountDoNotExist_ReturnsNull()
    {
        // Arrange
        var accountId = Guid.NewGuid();

        // Act
        var result = await _accountRepository.GetAccountWithOutfitsAsync(accountId);

        // Assert
        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task GetSearchedAccountsAsync_AccountsExists_ReturnsAccounts()
    {
        // Arrange
        var searchTerm = "AccountTest";

        // Act
        var result = await _accountRepository.GetSearchedAccountsAsync(searchTerm);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            foreach (var account in _accounts)
            {
                Assert.That(result.Any(a => a.Id == account.Id && a.Username.ToLower().StartsWith(searchTerm.ToLower())), Is.True);
            }
        });
    }

    [Test]
    public async Task GetSearchedAccountsAsync_AccountDoNotExist_ReturnsEmptyList()
    {
        // Arrange
        var searchTerm = "Test";

        // Act
        var result = await _accountRepository.GetSearchedAccountsAsync(searchTerm);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);
        });
    }

    [Test]
    public async Task GetAllOutfitsAndItemsIdsForAccount_AccountWithOutfitsAndItemsExist_ReturnsIds()
    {
        // Arrange
        var accountId = _accounts.First().Id;

        // Act
        var result = await _accountRepository.GetAllOutfitsAndItemsIdsForAccount(accountId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(_outfits.Count + _items.Count));
            foreach (var outfit in _outfits)
            {
                Assert.That(result, Does.Contain(outfit.Id));
            }
            foreach (var item in _items)
            {
                Assert.That(result, Does.Contain(item.Id));
            }
        });
    }

    [Test]
    public async Task GetAllOutfitsAndItemsIdsForAccount_AccountWithoutOutfitsAndItemsExist_ReturnsEmptyList()
    {
        // Arrange
        var accountId = _accounts[1].Id;

        // Act
        var result = await _accountRepository.GetAllOutfitsAndItemsIdsForAccount(accountId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);
        });
    }
}