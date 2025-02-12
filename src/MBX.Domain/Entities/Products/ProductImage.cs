using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Products;

public class ProductImage : BaseEntity
{
    [Required]
    public Guid ProductId { get; set; } // ID sản phẩm (khóa ngoại đến bảng Product, bắt buộc)

    public virtual Product Product { get; set; } = null!; // Navigation property cho sản phẩm (bắt buộc)

    [Required]
    [MaxLength(255)]
    public string ImageUrl { get; set; } = string.Empty; // URL hình ảnh (bắt buộc, độ dài tối đa 255 ký tự)

    public bool IsThumbnail { get; set; } // Xác định hình ảnh là thumbnail (mặc định false)
    public int? Order { get; set; } // Thứ tự hiển thị hình ảnh (không bắt buộc)
}