using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Orders;

public class PaymentMethod : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string MethodName { get; set; } = string.Empty; // Tên phương thức thanh toán (ví dụ: "Thẻ tín dụng", "Chuyển khoản ngân hàng") (bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(1000)]
    public string? Description { get; set; } // Mô tả phương thức thanh toán (không bắt buộc, độ dài tối đa 1000 ký tự)

    #region Navigation properties

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>(); // Navigation property cho đơn hàng (danh sách các đơn hàng sử dụng phương thức thanh toán này)

    #endregion Navigation properties
}