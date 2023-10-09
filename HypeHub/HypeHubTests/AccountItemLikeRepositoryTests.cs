using HypeHubDAL.DbContexts;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubDAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HypeHubTests;

[TestFixture]
public class AccountItemLikeRepositoryTests
{
    private IAccountItemLikeRepository _accountItemLikeRepository;
    private HypeHubContext _dbContext;
    private static Guid _id = Guid.NewGuid();
    private static List<AccountItemLike> _accountItemLikes = new()
        {
            new AccountItemLike(Guid.NewGuid(), Guid.NewGuid()),
            new AccountItemLike(_id, _id),
            new AccountItemLike(_id, _id),
        };

    [OneTimeSetUp]
    public async Task Setup()
    {
        var options = new DbContextOptionsBuilder<HypeHubContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _dbContext = new HypeHubContext(options);
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.AccountItemLikes.AddRangeAsync(_accountItemLikes);
        await _dbContext.SaveChangesAsync();

        _accountItemLikeRepository = new AccountItemLikeRepository(_dbContext);
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
        var accountItemLike = _accountItemLikes.First();

        // Act
        var result = await _accountItemLikeRepository.GetAsyncByAccountAndItemId(accountItemLike);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result?.AccountId, Is.EqualTo(accountItemLike.AccountId));
            Assert.That(result?.ItemId, Is.EqualTo(accountItemLike.ItemId));
        });
    }

    [Test]
    public async Task GetAsyncByAccountAndOutfitId_AccountOutfitLikeDoNotExist_ReturnsNull()
    {
        // Arrange
        var accountItemLike = new AccountItemLike(Guid.NewGuid(), Guid.NewGuid());

        // Act
        var result = await _accountItemLikeRepository.GetAsyncByAccountAndItemId(accountItemLike);

        // Assert
        Assert.That(result, Is.Null);
    }

    [Test]
    public void GetAsyncByAccountAndOutfitId_AccountOutfitLikeExistsTwoTimes_ThrowMoreThanOneElementException()
    {
        // Arrange
        var accountItemLike = _accountItemLikes[1];

        // Assert
        Assert.ThrowsAsync<InvalidOperationException>(async () => await _accountItemLikeRepository.GetAsyncByAccountAndItemId(accountItemLike));
    }
}