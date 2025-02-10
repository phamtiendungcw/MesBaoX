using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Orders;

public class Shipment : BaseEntity
{
    [Required] public Guid OrderId { get; set; } // ID đơn hàng (khóa ngoại đến bảng Order, bắt buộc)
    public virtual Order Order { get; set; } = null!; // Navigation property cho đơn hàng (bắt buộc)
    [MaxLength(255)] public string? ShippingCarrier { get; set; } // Đơn vị vận chuyển (ví dụ: "Giao hàng nhanh", "VNPost") (không bắt buộc, độ dài tối đa 255 ký tự)
    [MaxLength(255)] public string? TrackingNumber { get; set; } // Mã vận đơn (không bắt buộc, độ dài tối đa 255 ký tự, dùng để theo dõi lô hàng)
    public DateTime? ShipmentDate { get; set; } // Ngày gửi hàng (không bắt buộc)
    public DateTime? EstimatedDeliveryDate { get; set; } // Ngày giao hàng dự kiến (không bắt buộc)
    public DateTime? ActualDeliveryDate { get; set; } // Ngày giao hàng thực tế (không bắt buộc)
    [MaxLength(255)] public string? ShipmentStatus { get; set; } // Trạng thái lô hàng (ví dụ: "Đang lấy hàng", "Đang vận chuyển", "Đã giao hàng") (không bắt buộc, độ dài tối đa 255 ký tự)

    #region Navigation properties

    public virtual ICollection<OrderItemShipment> OrderItemShipments { get; set; } = new List<OrderItemShipment>(); // Navigation property cho chi tiết lô hàng (danh sách chi tiết lô hàng của lô hàng này)

    #endregion
}