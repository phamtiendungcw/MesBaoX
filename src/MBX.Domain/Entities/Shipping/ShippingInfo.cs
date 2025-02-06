using MBX.Domain.Common;

namespace MBX.Domain.Entities.Shipping
{
    public class ShippingInfo : BaseEntity
    {
        public string ShippingMethod { get; set; } = string.Empty; // Phương thức vận chuyển - Non-nullable, default to empty string
        public DateTime? ShippedDate { get; set; } // Ngày giao hàng (tùy chọn) - Nullable
        public DateTime? DeliveredDate { get; set; } // Ngày giao thành công (tùy chọn) - Nullable
        public string? TrackingNumber { get; set; } // Mã theo dõi vận chuyển (tùy chọn) - Nullable
        public string Status { get; set; } = string.Empty; // Trạng thái vận chuyển - Non-nullable, default to empty string (Consider enum default if applicable)
        public decimal ShippingCost { get; set; } // Chi phí vận chuyển
        public string? Carrier { get; set; } // Hãng vận chuyển (tùy chọn) - Nullable
        public string? ShippingAddressDetails { get; set; } // Chi tiết địa chỉ giao hàng (tùy chọn) - Nullable
        public string? BillingAddressDetails { get; set; } // Chi tiết địa chỉ thanh toán (tùy chọn) - Nullable
        public string? Notes { get; set; } // Ghi chú vận chuyển (tùy chọn) - Nullable
        public Guid OrderId { get; set; } // ID đơn hàng
        public Order.Order Order { get; set; } = null!; // Đơn hàng mà ShippingInfo thuộc về (Navigation)

    }
}
