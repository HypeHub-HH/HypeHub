using HypeHubDAL.DbContexts;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubDAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HypeHubTests.RepositoriesTests;

[TestFixture]
public class OutfitImageRepositoryTests
{
    private IOutfitImageRepository _outfitImageRepository;
    private HypeHubContext _dbContext;
    private static readonly Guid _id = Guid.NewGuid();
    private static readonly List<OutfitImage> _outfitImages = new()
        {
            new OutfitImage(_id, "TestURL1"),
            new OutfitImage(_id, "TestURL2"),
        };

    [OneTimeSetUp]
    public async Task Setup()
    {
        var options = new DbContextOptionsBuilder<HypeHubContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
        _dbContext = new HypeHubContext(options);
        await _dbContext.Database.EnsureCreatedAsync();
        await _dbContext.OutfitImages.AddRangeAsync(_outfitImages);
        await _dbContext.SaveChangesAsync();
        _outfitImageRepository = new OutfitImageRepository(_dbContext);
    }

    [OneTimeTearDown]
    public async Task TearDown()
    {
        await _dbContext.Database.EnsureDeletedAsync();
        await _dbContext.DisposeAsync();
    }

    [Test]
    public async Task GetAllOutfitImagesAsync_OutfitImagesExists_ReturnsItemImages()
    {
        // Arrange
        var OutfitId = _id;

        // Act
        var result = await _outfitImageRepository.GetAllOutfitImagesAsync(OutfitId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            foreach (var itemImage in result)
            {
                Assert.That(itemImage.OutfitId, Is.EqualTo(OutfitId));
            }
        });
    }

    [Test]
    public async Task GetAllOutfitImagesAsync_OutfitImagesDoNotExists_ReturnsEmptyList()
    {
        // Arrange
        var OutfitId = Guid.NewGuid();

        // Act
        var result = await _outfitImageRepository.GetAllOutfitImagesAsync(OutfitId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);
        });
    }
}