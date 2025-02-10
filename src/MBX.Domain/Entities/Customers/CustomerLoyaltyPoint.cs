using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Customers;

public class CustomerLoyaltyPoint : BaseEntity
{
    [Required] public Guid CustomerId { get; set; } // ID khách hàng (khóa ngoại đến bảng Customer, bắt buộc)
    public virtual Customer Customer { get; set; } = null!; // Navigation property cho khách hàng (bắt buộc)
    public int PointsEarned { get; set; } // Điểm tích lũy được (bắt buộc)
    public int PointsRedeemed { get; set; } // Điểm đã sử dụng (bắt buộc)
    public DateTime TransactionDate { get; set; } = DateTime.UtcNow; // Ngày giao dịch điểm (mặc định UTC now)
    [MaxLength(1000)] public string? Description { get; set; } // Mô tả giao dịch điểm (ví dụ: "Mua hàng đơn hàng #123", "Đổi điểm lấy voucher") (không bắt buộc, độ dài tối đa 1000 ký tự)
}