using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Orders;

public class ShippingMethod : BaseEntity
{
    [Required][MaxLength(255)] public string MethodName { get; set; } = string.Empty; // Tên phương thức vận chuyển (ví dụ: "Giao hàng nhanh", "Giao hàng tiết kiệm") (bắt buộc, độ dài tối đa 255 ký tự)
    [MaxLength(1000)] public string? Description { get; set; } // Mô tả phương thức vận chuyển (không bắt buộc, độ dài tối đa 1000 ký tự)
    [Column(TypeName = "decimal(18, 2)")] public decimal Cost { get; set; } // Chi phí vận chuyển (bắt buộc, kiểu decimal với 2 số thập phân)
    [MaxLength(255)] public string? EstimatedDeliveryTime { get; set; } // Thời gian giao hàng dự kiến (không bắt buộc, độ dài tối đa 255 ký tự)

    #region Navigation properties

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>(); // Navigation property cho đơn hàng (danh sách các đơn hàng sử dụng phương thức vận chuyển này)

    #endregion
}