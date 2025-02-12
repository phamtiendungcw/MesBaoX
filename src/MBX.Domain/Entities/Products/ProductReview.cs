using MBX.Domain.Entities.Customers;

using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Products;

public class ProductReview : BaseEntity
{
    [Required]
    public Guid ProductId { get; set; } // ID sản phẩm (khóa ngoại đến bảng Product, bắt buộc)

    public virtual Product Product { get; set; } = null!; // Navigation property cho sản phẩm (bắt buộc)
    public Guid? CustomerId { get; set; } // ID khách hàng (khóa ngoại đến bảng Customer, có thể null nếu đánh giá ẩn danh)
    public virtual Customer? Customer { get; set; } // Navigation property cho khách hàng (có thể null)

    [Required]
    [Range(1, 5)] // Đảm bảo rating từ 1 đến 5 sao
    public int Rating { get; set; } // Số sao đánh giá (bắt buộc, từ 1 đến 5)

    [MaxLength(4000)]
    public string? Comment { get; set; } // Bình luận đánh giá (không bắt buộc, độ dài tối đa 4000 ký tự)

    public bool IsApproved { get; set; } // Trạng thái duyệt đánh giá (mặc định false - chưa duyệt, cần quản trị viên duyệt)
}