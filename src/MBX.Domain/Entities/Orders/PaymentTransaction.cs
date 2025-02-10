using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Orders;

public class PaymentTransaction : BaseEntity
{
    [Required] public Guid OrderId { get; set; } // ID đơn hàng (khóa ngoại đến bảng Order, bắt buộc)
    public virtual Order Order { get; set; } = null!; // Navigation property cho đơn hàng (bắt buộc)
    public DateTime TransactionDate { get; set; } = DateTime.UtcNow; // Ngày giao dịch (mặc định UTC now)
    [Column(TypeName = "decimal(18, 2)")] public decimal TransactionAmount { get; set; } // Số tiền giao dịch (bắt buộc, kiểu decimal với 2 số thập phân)
    [Required][MaxLength(255)] public string TransactionStatus { get; set; } = string.Empty; // Trạng thái giao dịch (ví dụ: "Thành công", "Thất bại", "Đang chờ") (bắt buộc, độ dài tối đa 255 ký tự)
    [MaxLength(255)] public string? PaymentGateway { get; set; } // Cổng thanh toán (ví dụ: "PayPal", "Stripe", "VNPay") (không bắt buộc, độ dài tối đa 255 ký tự)
    [MaxLength(255)] public string? TransactionId { get; set; } // ID giao dịch từ cổng thanh toán (không bắt buộc, độ dài tối đa 255 ký tự, dùng để tham chiếu giao dịch từ cổng thanh toán)
}