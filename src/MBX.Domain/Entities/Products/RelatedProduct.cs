using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Products;

public class RelatedProduct : BaseEntity
{
    [Required]
    public Guid ProductId { get; set; } // ID sản phẩm chính (khóa ngoại đến bảng Product, bắt buộc)

    [ForeignKey("ProductId")] // DataAnnotation để chỉ định rõ tên cột khóa ngoại trong DB
    public virtual Product Product { get; set; } = null!; // Navigation property cho sản phẩm chính (bắt buộc)

    [Required]
    public Guid RelatedToProductId { get; set; } // ID sản phẩm liên quan (khóa ngoại đến bảng Product, bắt buộc)

    [ForeignKey("RelatedToProductId")] // DataAnnotation để chỉ định rõ tên cột khóa ngoại trong DB
    public virtual Product RelatedToProduct { get; set; } = null!; // Navigation property cho sản phẩm liên quan (bắt buộc)

    [MaxLength(255)]
    public string? RelationType { get; set; } // Loại quan hệ (ví dụ: "Tương tự", "Mua kèm") (không bắt buộc, độ dài tối đa 255 ký tự)
}