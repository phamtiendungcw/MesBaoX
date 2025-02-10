using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Products;

public class Category : BaseEntity
{
    [Required][MaxLength(255)] public string CategoryName { get; set; } = string.Empty; // Tên danh mục (bắt buộc, độ dài tối đa 255 ký tự)
    [MaxLength(1000)] public string? Description { get; set; } // Mô tả danh mục (không bắt buộc, độ dài tối đa 1000 ký tự)

    #region Navigation properties

    public Guid? ParentCategoryId { get; set; } // ID danh mục cha (khóa ngoại đến bảng Category, có thể null nếu là danh mục gốc)
    public virtual Category? ParentCategory { get; set; } // Navigation property cho danh mục cha (có thể null)
    public virtual ICollection<Category> ChildCategories { get; set; } = new List<Category>(); // Navigation property cho danh mục con (danh sách các danh mục con)
    public virtual ICollection<Product> Products { get; set; } = new List<Product>(); // Navigation property cho sản phẩm (danh sách các sản phẩm thuộc danh mục này)
    [Required][MaxLength(255)] public string Slug { get; set; } = string.Empty; // Slug URL thân thiện (bắt buộc, độ dài tối đa 255 ký tự, thường dùng cho URL)

    #endregion
}