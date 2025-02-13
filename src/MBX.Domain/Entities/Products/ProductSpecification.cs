using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Products;

public class ProductSpecification : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string SpecificationName { get; set; } = string.Empty; // Tên thông số kỹ thuật (ví dụ: "Chất liệu", "Kích thước màn hình") (bắt buộc, độ dài tối đa 255 ký tự)

    [Required]
    [MaxLength(1000)]
    public string SpecificationValue { get; set; } = string.Empty; // Giá trị thông số kỹ thuật (ví dụ: "Cotton 100%", "6.7 inch") (bắt buộc, độ dài tối đa 1000 ký tự)

    [Required]
    public Guid ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;
}