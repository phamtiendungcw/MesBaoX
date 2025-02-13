using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Products;

public class ProductTag : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string TagName { get; set; } = string.Empty; // Tên tag sản phẩm (ví dụ: "Hàng mới", "Bán chạy nhất") (bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(1000)]
    public string? Description { get; set; } // Mô tả tag sản phẩm (không bắt buộc, độ dài tối đa 1000 ký tự)

    public virtual ICollection<Product> Products { get; set; } = new List<Product>(); // Navigation property cho sản phẩm (quan hệ Many-to-Many, danh sách các sản phẩm được gắn tag này)
}