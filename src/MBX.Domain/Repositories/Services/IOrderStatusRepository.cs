using MBX.Domain.Entities.Orders;

namespace MBX.Domain.Repositories.Services;

public interface IOrderStatusRepository : IGenericRepository<OrderStatus>
{
    Task<OrderStatus?> GetOrderStatusByNameAsync(string statusName);
    Task<IReadOnlyList<OrderStatus>> GetActiveOrderStatusesAsync();
}