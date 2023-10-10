using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubDAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HypeHubTests;

[TestFixture]
public class ItemImageRepositoryTests
{
    private IItemImageRepository _itemImageRepository;
    private HypeHubContext _dbContext;
    private static Guid _id = Guid.NewGuid();
    private static List<ItemImage> _itemImages = new()
        {
            new ItemImage(_id, "TestURL1"),
            new ItemImage(_id, "TestURL2"),
        };

    [OneTimeSetUp]
    public async Task Setup()
    {
        var options = new DbContextOptionsBuilder<HypeHubContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _dbContext = new HypeHubContext(options);
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.ItemsImages.AddRangeAsync(_itemImages);
        await _dbContext.SaveChangesAsync();

        _itemImageRepository = new ItemImageRepository(_dbContext);
    }

    [OneTimeTearDown]
    public async Task TearDown()
    {
        await _dbContext.Database.EnsureDeletedAsync();
        await _dbContext.DisposeAsync();
    }

    [Test]
    public async Task GetAllItemImagesAsync_ItemImagesExists_ReturnsItemImages()
    {
        // Arrange
        var ItemId = _id;

        // Act
        var result = await _itemImageRepository.GetAllItemImagesAsync(ItemId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            foreach (var itemImage in result)
            {
                Assert.That(itemImage.ItemId, Is.EqualTo(ItemId));
            }
        });
    }

    [Test]
    public async Task GetAllItemImagesAsync_ItemImagesDoNotExists_ReturnsEmptyList()
    {
        // Arrange
        var ItemId = Guid.NewGuid();

        // Act
        var result = await _itemImageRepository.GetAllItemImagesAsync(ItemId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);
        });
    }
}