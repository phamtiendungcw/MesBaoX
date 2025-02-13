using MBX.Domain.Entities.Inventory;

namespace MBX.Domain.Repositories.Services;

public interface IWarehouseRepository : IGenericRepository<Warehouse>
{
    Task<Warehouse?> GetWarehouseByNameAsync(string warehouseName);
    Task<IReadOnlyList<Warehouse>> GetActiveWarehousesAsync();
    Task<IReadOnlyList<Warehouse>> GetWarehousesByCityAsync(string city);
}