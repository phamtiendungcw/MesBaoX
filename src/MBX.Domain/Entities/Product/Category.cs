using MBX.Domain.Common;
using MBX.Domain.Entities.Core;

namespace MBX.Domain.Entities.Product;

public class Category : BaseEntity
{
    public Guid CompanyId { get; set; } // ID công ty
    public Company Company { get; set; } = null!; // Công ty mà danh mục sản phẩm thuộc về (Navigation)
    public string Name { get; set; } = string.Empty; // Tên danh mục sản phẩm - Non-nullable, default to empty string
    public string? Description { get; set; } // Mô tả danh mục sản phẩm (tùy chọn) - Nullable
    public Guid? ParentCategoryId { get; set; } // ID danh mục cha (tùy chọn)
    public Category? ParentCategory { get; set; } // Danh mục cha (Navigation)
    public string? CategoryCode { get; set; } // Mã danh mục (tùy chọn) - Nullable
    public string? ImageUrl { get; set; } // URL hình ảnh danh mục (tùy chọn) - Nullable
    public ICollection<Category> ChildCategories { get; set; } = new List<Category>(); // Danh sách danh mục con (Navigation)
    public ICollection<Product> Products { get; set; } = new List<Product>(); // Danh sách sản phẩm thuộc danh mục (Navigation)
}