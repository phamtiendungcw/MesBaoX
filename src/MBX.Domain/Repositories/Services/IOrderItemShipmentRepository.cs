using MBX.Domain.Entities.Orders;

namespace MBX.Domain.Repositories.Services;

public interface IOrderItemShipmentRepository : IGenericRepository<OrderItemShipment>
{
    Task<IReadOnlyList<OrderItemShipment>> GetOrderItemShipmentsByShipmentAsync(Guid shipmentId);
    Task<IReadOnlyList<OrderItemShipment>> GetOrderItemShipmentsByOrderItemAsync(Guid orderItemId);
}