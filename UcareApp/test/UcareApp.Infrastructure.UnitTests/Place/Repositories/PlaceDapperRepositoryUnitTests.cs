using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Xunit;
using Dapper;
using UcareApp.Core.Place.Base;
using UcareApp.Infrastructure.Place.Repositories;
using UcareApp.Core.Place.Enums;
using UcareApp.Core.Place.Models;
using UcareApp.Core.Maintenance.Models;
using UcareApp.Infrastructure.Place.Services;

namespace UcareApp.Tests.Core.Place.Repositories;

public class PlaceDapperRepositoryTests
{
    [Fact]
    public async Task GetAllAsync_ShouldReturnAllPlaces()
    {
        Mock<IPlaceRepository> placeRepositoryMock = new Mock<IPlaceRepository>();

        placeRepositoryMock.Setup((repo) => repo.GetAllAsync())
                .ReturnsAsync([new UcareApp.Core.Place.Models.Place() {
                    Name = "test"
                }]);

        var placeService = new PlaceService(placeRepository: placeRepositoryMock.Object);

        await placeService.GetAllPlacesAsync();
    }

    [Fact]
    public async Task GetByIdAsync_ShouldReturnPlaceById()
    {
        Mock<IPlaceRepository> placeRepositoryMock = new Mock<IPlaceRepository>();
        Guid id = Guid.NewGuid();
        placeRepositoryMock.Setup((repo) => repo.GetByIdAsync(id))
                .ReturnsAsync(new UcareApp.Core.Place.Models.Place() {
                    Name = "test"
                });

        var placeService = new PlaceService(placeRepository: placeRepositoryMock.Object);

        await placeService.GetPlaceByIdAsync(id);
    }

    [Fact]
    public async Task CreateAsync_ShouldAddPlace()
    {
        Mock<IPlaceRepository> placeRepositoryMock = new Mock<IPlaceRepository>();
        UcareApp.Core.Place.Models.Place newPlace = new UcareApp.Core.Place.Models.Place() { Name = "test"};
        placeRepositoryMock.Setup((repo) => repo.CreateAsync(newPlace));

        var placeService = new PlaceService(placeRepository: placeRepositoryMock.Object);

        await placeService.CreateNewPlaceAsync(newPlace);
    }

    [Fact]
    public async Task DeleteAsync_ShouldDeletePlace()
    {
        Mock<IPlaceRepository> placeRepositoryMock = new Mock<IPlaceRepository>();
        Guid id = Guid.NewGuid();
        placeRepositoryMock.Setup((repo) => repo.DeleteAsync(id));

        var placeService = new PlaceService(placeRepository: placeRepositoryMock.Object);

        await placeService.DeletePlaceAsync(id);
    }

    [Fact]
    public async Task UpdateAsync_ShouldUpdatePlace()
    {
        Mock<IPlaceRepository> placeRepositoryMock = new Mock<IPlaceRepository>();
        UcareApp.Core.Place.Models.Place place = new UcareApp.Core.Place.Models.Place() { Name = "test"};
        placeRepositoryMock.Setup((repo) => repo.UpdateAsync(place));

        var placeService = new PlaceService(placeRepository: placeRepositoryMock.Object);

        await placeService.UpdatePlaceAsync(place);
    }
}
