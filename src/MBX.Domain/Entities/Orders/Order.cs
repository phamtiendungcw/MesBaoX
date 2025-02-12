using MBX.Domain.Entities.Customers;
using MBX.Domain.Entities.Promotions;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Orders;

public class Order : BaseEntity
{
    [Required]
    public Guid CustomerId { get; set; } // ID khách hàng (khóa ngoại đến bảng Customer, bắt buộc)

    public virtual Customer Customer { get; set; } = null!; // Navigation property cho khách hàng (bắt buộc)
    public DateTime OrderDate { get; set; } = DateTime.UtcNow; // Ngày đặt hàng (mặc định UTC now)

    [Required]
    public Guid OrderStatusId { get; set; } // ID trạng thái đơn hàng (khóa ngoại đến bảng OrderStatus, bắt buộc)

    public virtual OrderStatus OrderStatus { get; set; } = null!; // Navigation property cho trạng thái đơn hàng (bắt buộc)

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalAmount { get; set; } // Tổng tiền đơn hàng (bắt buộc, kiểu decimal với 2 số thập phân)

    [Required]
    public Guid ShippingAddressId { get; set; } // ID địa chỉ giao hàng (khóa ngoại đến bảng Address, bắt buộc)

    public virtual Address ShippingAddress { get; set; } = null!; // Navigation property cho địa chỉ giao hàng (bắt buộc)

    [Required]
    public Guid BillingAddressId { get; set; } // ID địa chỉ thanh toán (khóa ngoại đến bảng Address, bắt buộc)

    public virtual Address BillingAddress { get; set; } = null!; // Navigation property cho địa chỉ thanh toán (bắt buộc)
    public Guid? PaymentMethodId { get; set; } // ID phương thức thanh toán (khóa ngoại đến bảng PaymentMethod, có thể null nếu chưa chọn hoặc phương thức không xác định)
    public virtual PaymentMethod? PaymentMethod { get; set; } // Navigation property cho phương thức thanh toán (có thể null)
    public Guid? ShippingMethodId { get; set; } // ID phương thức vận chuyển (khóa ngoại đến bảng ShippingMethod, có thể null nếu chưa chọn hoặc phương thức không xác định)
    public virtual ShippingMethod? ShippingMethod { get; set; } // Navigation property cho phương thức vận chuyển (có thể null)

    [MaxLength(4000)]
    public string? OrderNotes { get; set; } // Ghi chú đơn hàng (không bắt buộc, độ dài tối đa 4000 ký tự)

    [Required]
    [MaxLength(50)]
    public string OrderNumber { get; set; } = string.Empty; // Mã số đơn hàng (bắt buộc, độ dài tối đa 50 ký tự, thường tự động sinh)

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DiscountAmount { get; set; } // Tiền giảm giá (không bắt buộc, kiểu decimal với 2 số thập phân, từ mã giảm giá hoặc khuyến mãi)

    #region Navigation properties

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); // Navigation property cho chi tiết đơn hàng (danh sách các chi tiết đơn hàng của đơn hàng này)
    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>(); // Navigation property cho giao dịch thanh toán (danh sách các giao dịch thanh toán của đơn hàng này)
    public virtual ICollection<OrderCoupon> OrderCoupons { get; set; } = new List<OrderCoupon>(); // Navigation property cho mã giảm giá sử dụng (quan hệ Many-to-Many, danh sách các mã giảm giá được sử dụng trong đơn hàng)
    public virtual ICollection<OrderReturn> OrderReturns { get; set; } = new List<OrderReturn>(); // Navigation property cho trả hàng (danh sách các yêu cầu trả hàng liên quan đến đơn hàng này)
    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>(); // Navigation property cho lô hàng (danh sách các lô hàng của đơn hàng này)

    #endregion Navigation properties
}