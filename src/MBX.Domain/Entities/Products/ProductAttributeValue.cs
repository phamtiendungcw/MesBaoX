using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Products;

public class ProductAttributeValue : BaseEntity
{
    [Required] public Guid ProductAttributeId { get; set; } // ID thuộc tính sản phẩm (khóa ngoại đến bảng ProductAttribute, bắt buộc)
    public virtual ProductAttribute ProductAttribute { get; set; } = null!; // Navigation property cho thuộc tính sản phẩm (bắt buộc)
    [Required][MaxLength(255)] public string Value { get; set; } = string.Empty; // Giá trị thuộc tính (ví dụ: Đỏ, Xanh, Lớn, Nhỏ) (bắt buộc, độ dài tối đa 255 ký tự)

    #region Navigation properties

    public virtual ICollection<Product> Products { get; set; } = new List<Product>(); // Navigation property cho sản phẩm (quan hệ Many-to-Many, danh sách các sản phẩm có giá trị thuộc tính này)
    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>(); // Navigation property cho biến thể sản phẩm (quan hệ Many-to-Many, danh sách các biến thể sản phẩm có giá trị thuộc tính này)

    #endregion
}