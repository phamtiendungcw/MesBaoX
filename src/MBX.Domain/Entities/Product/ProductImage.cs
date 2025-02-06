using MBX.Domain.Common;

namespace MBX.Domain.Entities.Product;

public class ProductImage : BaseEntity
{
    public Guid ProductId { get; set; } // ID sản phẩm
    public Product Product { get; set; } = null!; // Sản phẩm mà hình ảnh thuộc về (Navigation)
    public string ImageUrl { get; set; } = string.Empty; // URL hình ảnh
    public bool IsDefault { get; set; } // Hình ảnh mặc định (true/false)
    public string? ImageAltText { get; set; } // Văn bản thay thế hình ảnh (tùy chọn)
    public string? ImageCaption { get; set; } // Chú thích hình ảnh (tùy chọn)
    public int DisplayOrder { get; set; } // Thứ tự hiển thị hình ảnh
}