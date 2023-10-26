using HypeHubDAL.DbContexts;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories;
using HypeHubDAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HypeHubTests.RepositoriesTests;

[TestFixture]
public class OutfitItemRepositoryTests
{
    private IOutfitItemRepository _outfitItemRepository;
    private HypeHubContext _dbContext;
    private static readonly List<OutfitItem> _outfitItems = new()
        {
            new OutfitItem(Guid.NewGuid(), Guid.NewGuid()),
            new OutfitItem(Guid.NewGuid(), Guid.NewGuid()),
        };

    [OneTimeSetUp]
    public async Task Setup()
    {
        var options = new DbContextOptionsBuilder<HypeHubContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
        _dbContext = new HypeHubContext(options);
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.OutfitItems.AddRangeAsync(_outfitItems);
        await _dbContext.SaveChangesAsync();
        _outfitItemRepository = new OutfitItemRepository(_dbContext);
    }

    [OneTimeTearDown]
    public async Task TearDown()
    {
        await _dbContext.Database.EnsureDeletedAsync();
        await _dbContext.DisposeAsync();
    }

    [Test]
    public async Task AddAsync_AddOutfitItem_ReturnsAddedOutfitItem()
    {
        // Arrange
        var outfitItemToAdd = new OutfitItem(Guid.NewGuid(), Guid.NewGuid());

        // Act
        var result = await _outfitItemRepository.AddAsync(outfitItemToAdd);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(outfitItemToAdd));
        });
    }

    [Test]
    public void AddAsync_AddNull_ThrowsArgumentNullException()
    {
        // Act
        Assert.ThrowsAsync<ArgumentNullException>(async () => await _outfitItemRepository.AddAsync(null));
    }

    [Test]
    public async Task DeleteAsync_OutfitItemExist_ReturnsNull()
    {
        // Arrange
        var outfitItemToDelete = _outfitItems[1];

        // Act
        await _outfitItemRepository.DeleteAsync(outfitItemToDelete);
        var deletedEntity = await _dbContext.OutfitItems.SingleOrDefaultAsync(outfitItem => outfitItem.OutfitId == outfitItemToDelete.OutfitId && outfitItem.ItemId == outfitItemToDelete.ItemId);

        // Assert
        Assert.That(deletedEntity, Is.Null);
    }

    [Test]
    public void DeleteAsync_DeleteNull_ThrowsArgumentNullException()
    {
        // Act
        Assert.ThrowsAsync<ArgumentNullException>(async () => await _outfitItemRepository.DeleteAsync(null));
    }
}