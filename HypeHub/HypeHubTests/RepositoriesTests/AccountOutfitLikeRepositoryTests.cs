using HypeHubDAL.DbContexts;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories;
using Microsoft.EntityFrameworkCore;
using HypeHubDAL.Repositories.Interfaces;

namespace HypeHubTests.RepositoriesTests;

[TestFixture]
public class AccountOutfitLikeRepositoryTests
{
    private IAccountOutfitLikeRepository _accountOutfitLikeRepository;
    private HypeHubContext _dbContext;
    private static readonly Guid _id = Guid.NewGuid();
    private static readonly List<AccountOutfitLike> _accountOutfitLikes = new()
        {
            new AccountOutfitLike(Guid.NewGuid(), Guid.NewGuid()),
            new AccountOutfitLike(_id, _id),
            new AccountOutfitLike(_id, _id),
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
        _accountOutfitLikeRepository = new AccountOutfitLikeRepository(_dbContext);
    }

    [OneTimeTearDown]
    public async Task TearDown()
    {
        await _dbContext.Database.EnsureDeletedAsync();
        await _dbContext.DisposeAsync();
    }

    [Test]
    public async Task GetAsyncByAccountAndOutfitId_AccountOutfitLikeExists_ReturnsAccountOutfitLike()
    {
        // Arrange
        var accountOutfitLike = _accountOutfitLikes.First();

        // Act
        var result = await _accountOutfitLikeRepository.GetAsyncByAccountAndOutfitId(accountOutfitLike);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result?.AccountId, Is.EqualTo(accountOutfitLike.AccountId));
            Assert.That(result?.OutfitId, Is.EqualTo(accountOutfitLike.OutfitId));
        });
    }

    [Test]
    public async Task GetAsyncByAccountAndOutfitId_AccountOutfitLikeDoNotExist_ReturnsNull()
    {
        // Arrange
        var accountOutfitLike = new AccountOutfitLike(Guid.NewGuid(), Guid.NewGuid());

        // Act
        var result = await _accountOutfitLikeRepository.GetAsyncByAccountAndOutfitId(accountOutfitLike);

        // Assert
        Assert.That(result, Is.Null);
    }

    [Test]
    public void GetAsyncByAccountAndOutfitId_AccountOutfitLikeExistsTwoTimes_ThrowMoreThanOneElementException()
    {
        // Arrange
        var accountOutfitLike = _accountOutfitLikes[1];

        // Assert
        Assert.ThrowsAsync<InvalidOperationException>(async () => await _accountOutfitLikeRepository.GetAsyncByAccountAndOutfitId(accountOutfitLike));
    }
}