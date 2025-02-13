using MBX.Domain.Entities.Orders;

namespace MBX.Domain.Repositories.Services;

public interface IOrderItemReturnRepository : IGenericRepository<OrderItemReturn>
{
    Task<IReadOnlyList<OrderItemReturn>> GetOrderItemReturnsByOrderReturnAsync(Guid orderReturnId);
    Task<IReadOnlyList<OrderItemReturn>> GetOrderItemReturnsByOrderItemAsync(Guid orderItemId);
}