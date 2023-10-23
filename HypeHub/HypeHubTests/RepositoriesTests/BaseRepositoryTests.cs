using HypeHubDAL.DbContexts;
using HypeHubDAL.Models.Types;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubDAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HypeHubTests.RepositoriesTests;

[TestFixture]
public class BaseRepositoryTests
{
    private IBaseRepository<Account> _baseRepository;
    private HypeHubContext _dbContext;
    private static readonly List<Account> _accounts = new()
        {
            new Account(Guid.NewGuid(), "AccountTest1", true, AccountTypes.User, null),
            new Account(Guid.NewGuid(), "AccountTest2", true, AccountTypes.User, null),
            new Account(Guid.NewGuid(), "AccountTest3", true, AccountTypes.User, null),
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
        await _dbContext.SaveChangesAsync();
        _baseRepository = new BaseRepository<Account>(_dbContext);
    }

    [OneTimeTearDown]
    public async Task TearDown()
    {
        await _dbContext.Database.EnsureDeletedAsync();
        await _dbContext.DisposeAsync();
    }

    [Test]
    public async Task GetAllAsync_AccountsExist_ReturnsAllAccounts()
    {
        // Act
        var result = await _baseRepository.GetAllAsync();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result?.Count, Is.EqualTo(_accounts.Count));
        });
    }

    [Test]
    public async Task GetByIdAsync_AccountExists_ReturnsAccount()
    {
        // Arrange
        var accountId = _accounts.First().Id;

        // Act
        var result = await _baseRepository.GetByIdAsync(accountId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result?.Id, Is.EqualTo(accountId));
        });
    }

    [Test]
    public async Task GetByIdAsync_AccountDoNotExists_ReturnsNull()
    {
        // Arrange
        var accountId = Guid.NewGuid();

        // Act
        var result = await _baseRepository.GetByIdAsync(accountId);

        // Assert
        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task AddAsync_AddAccount_ReturnsAddedAccount()
    {
        // Arrange
        var accountToAdd = new Account(Guid.NewGuid(), "AccountTest3", true, AccountTypes.User, null);

        // Act
        var result = await _baseRepository.AddAsync(accountToAdd);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(accountToAdd));
        });
    }

    [Test]
    public void AddAsync_AddNull_ThrowsArgumentNullException()
    {
        // Act
        Assert.ThrowsAsync<ArgumentNullException>(async () => await _baseRepository.AddAsync(null));
    }

    [Test]
    public async Task UpdateAsync_UpdateAccount_ReturnsUpdatedAccount()
    {
        // Arrange
        var accountToUpdate = _accounts[2];
        accountToUpdate.IsPrivate = accountToUpdate.IsPrivate!;
        accountToUpdate.Username = "Test";

        // Act
        var result = await _baseRepository.UpdateAsync(accountToUpdate);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(accountToUpdate));
        });
    }

    [Test]
    public void UpdateAsync_UpdateNull_ThrowsArgumentNullException()
    {
        // Act
        Assert.ThrowsAsync<ArgumentNullException>(async () => await _baseRepository.UpdateAsync(null));
    }

    [Test]
    public async Task DeleteAsync_AccountExist_ReturnsNull()
    {
        // Arrange
        var accountToDelete = _accounts[1];

        // Act
        await _baseRepository.DeleteAsync(accountToDelete);
        var deletedEntity = await _dbContext.Accounts.FindAsync(accountToDelete.Id);

        // Assert
        Assert.That(deletedEntity, Is.Null);
    }

    [Test]
    public void DeleteAsync_DeleteNull_ThrowsArgumentNullException()
    {
        // Act
        Assert.ThrowsAsync<ArgumentNullException>(async () => await _baseRepository.DeleteAsync(null));
    }
}