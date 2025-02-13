using MBX.Domain.Entities.Orders;

namespace MBX.Domain.Repositories.Services;

public interface IOrderReturnRepository : IGenericRepository<OrderReturn>
{
    Task<IReadOnlyList<OrderReturn>> GetOrderReturnsByCustomerAsync(Guid customerId);
    Task<IReadOnlyList<OrderReturn>> GetOrderReturnsByStatusAsync(Guid returnStatusId);
    Task<IReadOnlyList<OrderReturn>> GetOrderReturnsCreatedAfterDateAsync(DateTime date);
}