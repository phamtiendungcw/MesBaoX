using MBX.Domain.Entities.Inventory;

namespace MBX.Domain.Repositories.Services;

public interface IStockMovementRepository : IGenericRepository<StockMovement>
{
    Task<IReadOnlyList<StockMovement>> GetStockMovementsForProductAsync(Guid productId);
    Task<IReadOnlyList<StockMovement>> GetStockMovementsByWarehouseAsync(Guid warehouseId);
    Task<IReadOnlyList<StockMovement>> GetStockMovementsByTypeAsync(string movementType);
    Task<IReadOnlyList<StockMovement>> GetStockMovementsInDateRangeAsync(DateTime startDate, DateTime endDate);
}