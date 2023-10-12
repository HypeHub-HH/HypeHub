using HypeHubDAL.DbContexts;
using HypeHubDAL.Models.Types;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubDAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HypeHubTests.RepositoriesTests;

[TestFixture]
public class BaseImageRepositoryTests
{
    private IBaseImageRepository<OutfitImage> _baseImageRepository;
    private HypeHubContext _dbContext;
    private static List<OutfitImage> _outfitImages = new()
        {
            new OutfitImage(Guid.NewGuid(), "URLTest1"),
            new OutfitImage(Guid.NewGuid(), "URLTest2"),
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

        _baseImageRepository = new BaseImageRepository<OutfitImage>(_dbContext);
    }

    [OneTimeTearDown]
    public async Task TearDown()
    {
        await _dbContext.Database.EnsureDeletedAsync();
        await _dbContext.DisposeAsync();
    }

    [Test]
    public async Task GetByIdAsync_OutfitImageExists_ReturnsOutfitImage()
    {
        // Arrange
        var outfitImageId = _outfitImages.First().Id;

        // Act
        var result = await _baseImageRepository.GetByIdAsync(outfitImageId);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result?.Id, Is.EqualTo(outfitImageId));
        });
    }

    [Test]
    public async Task GetByIdAsync_OutfitImageDoNotExists_ReturnsNull()
    {
        // Arrange
        var outfitImageId = Guid.NewGuid();

        // Act
        var result = await _baseImageRepository.GetByIdAsync(outfitImageId);

        // Assert
        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task AddAsync_AddOutfitImage_ReturnsAddedOutfitImage()
    {
        // Arrange
        var outfitImageToAdd = new OutfitImage(Guid.NewGuid(), "URLTest3");

        // Act
        var result = await _baseImageRepository.AddAsync(outfitImageToAdd);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(outfitImageToAdd));
        });
    }

    [Test]
    public void AddAsync_AddNull_ThrowsArgumentNullException()
    {
        // Act
        Assert.ThrowsAsync<ArgumentNullException>(async () => await _baseImageRepository.AddAsync(null));
    }

    [Test]
    public async Task DeleteAsync_OutfitImageExist_ReturnsNull()
    {
        // Arrange
        var outfitImageToDelete = _outfitImages[1];

        // Act
        await _baseImageRepository.DeleteAsync(outfitImageToDelete);
        var deletedEntity = await _dbContext.OutfitImages.FindAsync(outfitImageToDelete.Id);

        // Assert
        Assert.That(deletedEntity, Is.Null);
    }

    [Test]
    public void DeleteAsync_DeleteNull_ThrowsArgumentNullException()
    {
        // Act
        Assert.ThrowsAsync<ArgumentNullException>(async () => await _baseImageRepository.DeleteAsync(null));
    }
}