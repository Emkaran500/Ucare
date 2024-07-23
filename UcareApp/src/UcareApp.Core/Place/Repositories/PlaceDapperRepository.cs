namespace UcareApp.Core.Place.Repositories;

using UcareApp.Core.Place.Base;
using UcareApp.Core.Place.Models;
using System.Data.SqlClient;
using Dapper;
using Npgsql;

public class PlaceDapperRepository : IPlaceRepository
{
    private readonly string connectionString = "Server=ucarepostgresqlsrv.postgres.database.azure.com;Database=postgres;Port=5432;User Id=ucare_admin;Password=Step_password;Ssl Mode=Require;";
    public async Task<IEnumerable<Place>> GetAllAsync()
    {
        using var connection = new NpgsqlConnection(this.connectionString);

        return await connection.QueryAsync<Place>("Select * from Places");
    }

    public async Task<Place> GetByIdAsync(Guid? id)
    {
        using var connection = new NpgsqlConnection(this.connectionString);

        return await connection.QueryFirstAsync<Place>($"Select * from Places Where Places.Id = '{id}'");
    }

    public async Task CreateAsync(Place? newPlace)
    {
        using var connection = new NpgsqlConnection(this.connectionString);

        await connection.ExecuteAsync($@"Insert into Places(Name, Adress, Longitude, Latitude) Values ('{newPlace.Name}', '{newPlace.Adress}', {newPlace.Longitude}, {newPlace.Latitude});");
    }

    public async Task DeleteAsync(Guid? id)
    {
        using var connection = new NpgsqlConnection(this.connectionString);

        var placesIds = await connection.QueryAsync<Guid?>("Select Id From Places");

        var containsId = placesIds.Contains(id.Value);

        if (containsId)
        {
            await connection.ExecuteAsync("DELETE FROM Places WHERE Places.Id = @Id", new { Id = id });
        }
    }

    public async Task<long> UpdateAsync(Place? place)
    {
        using var connection = new NpgsqlConnection(this.connectionString);

        return await connection.ExecuteAsync($@"Update Places
                                                Set {nameof(place.Name)} = {place.Name},
                                                    {nameof(place.Adress)} = {place.Adress},
                                                    {nameof(place.Longitude)} = {place.Longitude},
                                                    {nameof(place.Latitude)} = {place.Latitude},
                                                    {nameof(place.WorkingDays)} = ARRAY{place.WorkingDays},
                                                    {nameof(place.Maintenances)} = ARRAY{place.Maintenances}
                                                Where Places.Id = {place.Id}");
    }
}
