using MBX.Domain.Entities.Products;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Orders;

public class OrderItem : BaseEntity
{
    [Required]
    public Guid OrderId { get; set; } // ID đơn hàng (khóa ngoại đến bảng Order, bắt buộc)

    public virtual Order Order { get; set; } = null!; // Navigation property cho đơn hàng (bắt buộc)

    [Required]
    public Guid ProductId { get; set; } // ID sản phẩm (khóa ngoại đến bảng Product, bắt buộc)

    public virtual Product Product { get; set; } = null!; // Navigation property cho sản phẩm (bắt buộc)
    public Guid? ProductVariantId { get; set; } // ID biến thể sản phẩm (khóa ngoại đến bảng ProductVariant, có thể null nếu không phải biến thể)
    public virtual ProductVariant? ProductVariant { get; set; } // Navigation property cho biến thể sản phẩm (có thể null)
    public int Quantity { get; set; } // Số lượng sản phẩm trong chi tiết đơn hàng (bắt buộc)

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; } // Giá sản phẩm tại thời điểm đặt hàng (bắt buộc, kiểu decimal với 2 số thập phân, quan trọng để lưu lại giá gốc khi có khuyến mãi)

    [MaxLength(255)]
    public string? ProductName { get; set; } // Tên sản phẩm (không bắt buộc, độ dài tối đa 255 ký tự, lưu lại để hiển thị thông tin đơn hàng ngay cả khi sản phẩm gốc bị thay đổi)

    public virtual ICollection<OrderItemReturn> OrderItemReturns { get; set; } = new List<OrderItemReturn>(); // Navigation property cho chi tiết trả hàng (danh sách chi tiết trả hàng liên quan đến chi tiết đơn hàng này)
    public virtual ICollection<OrderItemShipment> OrderItemShipments { get; set; } = new List<OrderItemShipment>(); // Navigation property cho chi tiết lô hàng (danh sách chi tiết lô hàng liên quan đến chi tiết đơn hàng này)
}