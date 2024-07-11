using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Xunit;
using Dapper;
using UcareApp.Core.Place.Repositories;
using UcareApp.Core.Place.Enums;
using UcareApp.Core.Place.Models;
using UcareApp.Core.Maintenance.Models;

namespace UcareApp.Tests.Core.Place.Repositories;

public class PlaceDapperRepositoryTests
{
    private readonly Mock<IDbConnection> mockDbConnection;
    private readonly PlaceDapperRepository repository;

    public PlaceDapperRepositoryTests()
    {
        this.mockDbConnection = new Mock<IDbConnection>();
        this.repository = new PlaceDapperRepository();
    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnAllPlaces()
    {
        
    }

    [Fact]
    public async Task GetByIdAsync_ShouldReturnPlaceById()
    {
    }

    [Fact]
    public async Task CreateAsync_ShouldAddPlace()
    {
    }

    [Fact]
    public async Task DeleteAsync_ShouldDeletePlace()
    {
    }

    [Fact]
    public async Task UpdateAsync_ShouldUpdatePlace()
    {
    }
}
