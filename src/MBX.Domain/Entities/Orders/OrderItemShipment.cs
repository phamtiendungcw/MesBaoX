using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Orders;

public class OrderItemShipment : BaseEntity
{
    [Required] public Guid ShipmentId { get; set; } // ID lô hàng (khóa ngoại đến bảng Shipment, bắt buộc)
    public virtual Shipment Shipment { get; set; } = null!; // Navigation property cho lô hàng (bắt buộc)
    [Required] public Guid OrderItemId { get; set; } // ID chi tiết đơn hàng (khóa ngoại đến bảng OrderItem, bắt buộc)
    public virtual OrderItem OrderItem { get; set; } = null!; // Navigation property cho chi tiết đơn hàng (bắt buộc)
    public int QuantityShipped { get; set; } // Số lượng sản phẩm đã giao trong lô hàng này (bắt buộc)
}