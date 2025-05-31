using System.Data;
using Dapper;
using Api.Models;
using Microsoft.Data.SqlClient;

namespace Api.Services
{
    public class InventoryService
    {
        private readonly IDbConnection _db;

        public InventoryService(IDbConnection db)
        {
            _db = db;
        }

        public async Task<IEnumerable<GalaDetails>> GetGalaDetailsAsync()
        {
            var sql = "SELECT * FROM GalaDetails";
            return await _db.QueryAsync<GalaDetails>(sql);
        }

        public async Task<IEnumerable<QualityDetails>> GetQualityDetailsAsync()
        {
            var sql = "SELECT * FROM QualityDetails";
            return await _db.QueryAsync<QualityDetails>(sql);
        }
        //public async Task<DBModels?> GetByIdAsync(int id)
        //{
        //    var sql = "SELECT Id, Name, Quantity FROM Inventory WHERE Id = @Id";
        //    return await _db.QueryFirstOrDefaultAsync<DBModels>(sql, new { Id = id });
        //}

        //public async Task<DBModels> AddAsync(DBModels inventory)
        //{
        //    var sql = @"INSERT INTO Inventory (Name, Quantity) 
        //                VALUES (@Name, @Quantity);
        //                SELECT CAST(SCOPE_IDENTITY() as int);";
        //    var id = await _db.ExecuteScalarAsync<int>(sql, inventory);
        //    inventory.Id = id;
        //    return inventory;
        //}

        //public async Task<bool> UpdateAsync(int id, DBModels inventory)
        //{
        //    var sql = "UPDATE Inventory SET Name = @Name, Quantity = @Quantity WHERE Id = @Id";
        //    var affected = await _db.ExecuteAsync(sql, new { inventory.Name, inventory.Quantity, Id = id });
        //    return affected > 0;
        //}

        //public async Task<bool> DeleteAsync(int id)
        //{
        //    var sql = "DELETE FROM Inventory WHERE Id = @Id";
        //    var affected = await _db.ExecuteAsync(sql, new { Id = id });
        //    return affected > 0;
        //}
    }
}