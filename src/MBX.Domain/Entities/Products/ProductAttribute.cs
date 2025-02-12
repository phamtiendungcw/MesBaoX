using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Products;

public class ProductAttribute : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string AttributeName { get; set; } = string.Empty; // Tên thuộc tính (ví dụ: Màu sắc, Kích thước) (bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(1000)]
    public string? Description { get; set; } // Mô tả thuộc tính (không bắt buộc, độ dài tối đa 1000 ký tự)

    #region Navigation properties

    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = new List<ProductAttributeValue>(); // Navigation property cho giá trị thuộc tính (danh sách các giá trị thuộc tính của thuộc tính này)

    #endregion Navigation properties
}