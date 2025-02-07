using MBX.Domain.Common;
using MBX.Domain.Entities.Core;
using MBX.Domain.Entities.Payment;
using MBX.Domain.Entities.Shipping;
using MBX.Domain.Entities.Support;

namespace MBX.Domain.Entities.Order;

public class Order : BaseEntity
{
    public string OrderNumber { get; set; } = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper(); // Mã đơn hàng (tự động tạo) - Non-nullable, default to auto-generated string
    public DateTime OrderDate { get; set; } = DateTime.UtcNow; // Ngày đặt hàng (mặc định UTC now)
    public decimal TotalAmount { get; set; } // Tổng tiền đơn hàng
    public string OrderStatus { get; set; } = string.Empty; // Trạng thái đơn hàng - Non-nullable, default to empty string (Consider enum default if applicable)
    public string? Notes { get; set; } // Ghi chú đơn hàng (tùy chọn) - Nullable
    public decimal DiscountAmount { get; set; } // Chiết khấu toàn đơn hàng
    public decimal TaxAmount { get; set; } // Thuế toàn đơn hàng
    public decimal ShippingFee { get; set; } // Phí vận chuyển
    public DateTime? ExpectedDeliveryDate { get; set; } // Ngày giao hàng dự kiến (tùy chọn) - Nullable
    public string OrderType { get; set; } = string.Empty; // Loại đơn hàng - Non-nullable, default to empty string (Consider enum default if applicable)
    public string? SourceChannel { get; set; } // Kênh bán hàng (tùy chọn) - Nullable
    public string? CampaignCode { get; set; } // Mã chiến dịch Marketing (tùy chọn) - Nullable
    public string? TrackingCode { get; set; } // Mã theo dõi đơn hàng (tùy chọn) - Nullable
    public Guid CustomerId { get; set; } // ID khách hàng
    public User Customer { get; set; } = null!; // Khách hàng (Navigation)
    public Guid? ShippingAddressId { get; set; } // ID địa chỉ giao hàng (tùy chọn)
    public Address ShippingAddress { get; set; } = null!; // Địa chỉ giao hàng (Navigation)
    public Guid? BillingAddressId { get; set; } // ID địa chỉ thanh toán (tùy chọn)
    public Address BillingAddress { get; set; } = null!; // Địa chỉ thanh toán (Navigation)
    public Guid? StoreId { get; set; } // ID cửa hàng (tùy chọn)
    public Store? Store { get; set; } // Cửa hàng (Navigation)
    public User? CreatedByUser { get; set; } // Người tạo đơn hàng (Navigation)
    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>(); // Danh sách OrderDetails (Navigation)
    public PaymentInfo PaymentInfo { get; set; } = null!; // Thông tin thanh toán (Navigation)
    public ShippingInfo ShippingInfo { get; set; } = null!; // Thông tin vận chuyển (Navigation)
}