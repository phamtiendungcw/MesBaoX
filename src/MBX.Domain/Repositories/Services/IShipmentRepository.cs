using MBX.Domain.Entities.Orders;

namespace MBX.Domain.Repositories.Services;

public interface IShipmentRepository : IGenericRepository<Shipment>
{
    Task<IReadOnlyList<Shipment>> GetShipmentsByOrderAsync(Guid orderId);
    Task<IReadOnlyList<Shipment>> GetShipmentsByStatusAsync(string shipmentStatus);
    Task<IReadOnlyList<Shipment>> GetShipmentsByCarrierAsync(string shippingCarrier);
}