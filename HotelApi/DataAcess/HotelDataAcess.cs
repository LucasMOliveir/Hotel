using HotelApi.Entities;
using Microsoft.Data.SqlClient;
using Dapper;

namespace HotelApi.DataAcess;

public class HotelDataAcess
{
    private readonly string _connectionString;

    public HotelDataAcess(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("HotelDatabase")
            ?? throw new InvalidOperationException(
                "A connection string 'HotelDatabase' não foi configurada.");
    }

    public async Task<IEnumerable<Hotel>> GetAllAsync()
    {
        const string sql = """
            SELECT HotelId, Name, DateCreated, DateUpdated, CreatedByUser
            FROM Hotel
            ORDER BY HotelId
        """;

        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        return await connection.QueryAsync<Hotel>(sql);
    }

    public async Task<Hotel?> GetById(long id)
    {
        const string sql = """
            SELECT HotelId, Name, DateCreated, DateUpdated, CreatedByUser
            FROM Hotel
            ORDER BY HotelId
            """;

        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        return await connection.QueryFirstOrDefaultAsync(sql, new { Id = id});
    }
}
