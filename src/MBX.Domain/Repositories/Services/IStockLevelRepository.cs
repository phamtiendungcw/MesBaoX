using MBX.Domain.Entities.Inventory;

namespace MBX.Domain.Repositories.Services;

public interface IStockLevelRepository : IGenericRepository<StockLevel>
{
    Task<StockLevel?> GetStockLevelByProductAndWarehouseAsync(Guid productId, Guid warehouseId);
    Task<IReadOnlyList<StockLevel>> GetStockLevelsForProductAsync(Guid productId);
    Task<IReadOnlyList<StockLevel>> GetStockLevelsByWarehouseAsync(Guid warehouseId);
    Task<IReadOnlyList<StockLevel>> GetStockLevelsBelowReorderPointAsync();
}