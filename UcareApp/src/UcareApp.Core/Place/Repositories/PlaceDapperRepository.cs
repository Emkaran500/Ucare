namespace UcareApp.Core.Place.Repositories;

using UcareApp.Core.Place.Base;
using UcareApp.Core.Place.Models;
using System.Data.SqlClient;
using Dapper;
using Npgsql;

public class PlaceDapperRepository : IPlaceRepository
{
    private readonly string connectionString = "Server={}.postgres.database.azure.com;Database={};Port=5432;User Id={};Password={};Ssl Mode=Require;";
    public async Task<IEnumerable<IPlace>> GetAllAsync(){
        using var connection = new NpgsqlConnection(this.connectionString);

        return await connection.QueryAsync<IPlace>("Select * from Places");
    }

    public async Task<IEnumerable<IPlace>> GetByIdAsync(int id){
        using var connection = new NpgsqlConnection(this.connectionString);

        return await connection.QueryAsync<IPlace>($"Select * from Places Where Places.Id = {id}");
    }

    public async Task CreateAsync(IPlace? newPlace)
    {
        using var connection = new NpgsqlConnection(this.connectionString);

        await connection.ExecuteAsync($@"Insert into Places({nameof(newPlace.Name)},
                                                            {nameof(newPlace.Adress)},
                                                            {nameof(newPlace.Longitude)},
                                                            {nameof(newPlace.Latitude)},
                                                            {nameof(newPlace.WorkingDays)},
                                                            {nameof(newPlace.Maintenances)}) 
                                         Values ({newPlace.Name},
                                                 {newPlace.Adress},
                                                 {newPlace.Longitude},
                                                 {newPlace.Latitude},
                                                 ARRAY{newPlace.WorkingDays},
                                                 ARRAY{newPlace.Maintenances})");
    }

    public async Task DeleteAsync(Guid? id)
    {
        using var connection = new NpgsqlConnection(this.connectionString);

        var placesIds = await connection.QueryAsync<int>("Select Id From Places");

        var containsId = placesIds.Contains(id.Value);

        if (containsId)
        {
            await connection.ExecuteAsync($"Delete from Places Where Places.Id = {id}");
        }
    }

    public async Task<long> UpdateAsync(IPlace? place)
    {
        using var connection = new NpgsqlConnection(this.connectionString);

        return await connection.ExecuteAsync($@"Update Places
                                                Set {nameof(place.Name)} = {place.Name},
                                                    {nameof(newPlace.Adress)} = {newPlace.Adress},
                                                    {nameof(newPlace.Longitude)} = {newPlace.Longitude},
                                                    {nameof(newPlace.Latitude)} = {newPlace.Latitude},
                                                    {nameof(newPlace.WorkingDays)} = ARRAY{newPlace.WorkingDays},
                                                    {nameof(newPlace.Maintenances)} = ARRAY{newPlace.Maintenances}
                                                Where Places.Id = {place.Id}");
    }
}