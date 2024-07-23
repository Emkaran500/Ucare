using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UcareApp.Core.Place.Models;
using UcareApp.Core.Place.Repositories;
using UcareApp.Core.Place.Services;
using UcareApp.Core.Place.Base;
using Xunit;

namespace UcareApp.Tests.Core.Place.Services;

public class PlaceServiceUnitTests
{
    private readonly Mock<IPlaceRepository> _placeRepositoryMock;
    private readonly PlaceService _placeService;

    public PlaceServiceUnitTests()
    {
        _placeRepositoryMock = new Mock<IPlaceRepository>();
        _placeService = new PlaceService(_placeRepositoryMock.Object);
    }

    [Fact]
    public async Task GetAllPlacesAsync_ReturnsAllPlaces()
    {
    }

    [Fact]
    public async Task GetPlaceByIdAsync_WithValidId_ReturnsPlace()
    {
    }

    [Fact]
    public async Task GetPlaceByIdAsync_WithNullId_ThrowsArgumentNullException()
    {
    }

    [Fact]
    public async Task CreateNewPlaceAsync_WithValidPlace_CreatesPlace()
    {
    }

    [Fact]
    public async Task CreateNewPlaceAsync_WithNullPlace_ThrowsArgumentNullException()
    {
    }

    [Fact]
    public async Task DeletePlaceAsync_WithValidId_DeletesPlace()
    {
    }

    [Fact]
    public async Task DeletePlaceAsync_WithNullId_ThrowsArgumentNullException()
    {
    }

    [Fact]
    public async Task UpdatePlaceAsync_WithValidPlace_UpdatesPlace()
    {
    }

    [Fact]
    public async Task UpdatePlaceAsync_WithNullPlace_ThrowsArgumentNullException()
    {
    }
}
