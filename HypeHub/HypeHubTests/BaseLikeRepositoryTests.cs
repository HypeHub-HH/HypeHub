using HypeHubDAL.DbContexts;
using HypeHubDAL.Models.Types;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubDAL.Repositories;
using Microsoft.EntityFrameworkCore;
using HypeHubDAL.Models.Relations;

namespace HypeHubTests;

[TestFixture]
public class BaseLikeRepositoryTests
{
    private IBaseLikeRepository<AccountOutfitLike> _baseLikeRepository;
    private HypeHubContext _dbContext;
    private static List<AccountOutfitLike> _accountOutfitLikes = new()
        {
            new AccountOutfitLike(Guid.NewGuid(), Guid.NewGuid()),
            new AccountOutfitLike(Guid.NewGuid(), Guid.NewGuid()),
        };

    [OneTimeSetUp]
    public async Task Setup()
    {
        var options = new DbContextOptionsBuilder<HypeHubContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _dbContext = new HypeHubContext(options);
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.AccountOutfitLikes.AddRangeAsync(_accountOutfitLikes);
        await _dbContext.SaveChangesAsync();

        _baseLikeRepository = new BaseLikeRepository<AccountOutfitLike>(_dbContext);
    }

    [OneTimeTearDown]
    public async Task TearDown()
    {
        await _dbContext.Database.EnsureDeletedAsync();
        await _dbContext.DisposeAsync();
    }

    [Test]
    public async Task AddAsync_AddAccountOutfitLike_ReturnsAddedAccountOutfitLike()
    {
        // Arrange
        var accountOutfitLikeToAdd = new AccountOutfitLike(Guid.NewGuid(), Guid.NewGuid());


        // Act
        var result = await _baseLikeRepository.AddAsync(accountOutfitLikeToAdd);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(accountOutfitLikeToAdd));
        });
    }

    [Test]
    public void AddAsync_AddNull_ThrowsArgumentNullException()
    {
        // Act
        Assert.ThrowsAsync<ArgumentNullException>(async () => await _baseLikeRepository.AddAsync(null));
    }

    [Test]
    public async Task DeleteAsync_AccountOutfitLikeExist_ReturnsNull()
    {
        // Arrange
        var accountOutfitLikeToDelete = _accountOutfitLikes[1];

        // Act
        await _baseLikeRepository.DeleteAsync(accountOutfitLikeToDelete);
        var deletedEntity = await _dbContext.AccountOutfitLikes.FindAsync(accountOutfitLikeToDelete.Id);

        // Assert
        Assert.That(deletedEntity, Is.Null);
    }

    [Test]
    public void DeleteAsync_DeleteNull_ThrowsArgumentNullException()
    {
        // Act
        Assert.ThrowsAsync<ArgumentNullException>(async () => await _baseLikeRepository.DeleteAsync(null));
    }
}