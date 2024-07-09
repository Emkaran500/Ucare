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
}