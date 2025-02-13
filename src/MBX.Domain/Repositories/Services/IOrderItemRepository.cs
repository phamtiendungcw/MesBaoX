using MBX.Domain.Entities.Orders;

namespace MBX.Domain.Repositories.Services;

public interface IOrderItemRepository : IGenericRepository<OrderItem>
{
    Task<IReadOnlyList<OrderItem>> GetOrderItemsByOrderAsync(Guid orderId);
    Task<IReadOnlyList<OrderItem>> GetOrderItemsByProductAsync(Guid productId);
    Task<IReadOnlyList<OrderItem>> GetOrderItemsByProductVariantAsync(Guid productVariantId);
}