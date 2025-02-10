using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Products;

public class Brand : BaseEntity
{
    [Required][MaxLength(255)] public string BrandName { get; set; } = string.Empty; // Tên thương hiệu (bắt buộc, độ dài tối đa 255 ký tự)
    [MaxLength(1000)] public string? Description { get; set; } // Mô tả thương hiệu (không bắt buộc, độ dài tối đa 1000 ký tự)
    [MaxLength(255)] public string? LogoUrl { get; set; } // URL logo thương hiệu (không bắt buộc, độ dài tối đa 255 ký tự)

    #region Navigation properties

    public virtual ICollection<Product> Products { get; set; } = new List<Product>(); // Navigation property cho sản phẩm (danh sách các sản phẩm thuộc thương hiệu này)
    [Required][MaxLength(255)] public string Slug { get; set; } = string.Empty; // Slug URL thân thiện (bắt buộc, độ dài tối đa 255 ký tự, thường dùng cho URL)

    #endregion
}