using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Orders;

public class OrderStatus : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string StatusName { get; set; } = string.Empty; // Tên trạng thái đơn hàng (ví dụ: "Chờ xác nhận", "Đang giao hàng") (bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(1000)]
    public string? Description { get; set; } // Mô tả trạng thái đơn hàng (không bắt buộc, độ dài tối đa 1000 ký tự)

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>(); // Navigation property cho đơn hàng (danh sách các đơn hàng có trạng thái này)
}