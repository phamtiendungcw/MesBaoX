using MBX.Domain.Entities.Inventory;
using MBX.Domain.Entities.Orders;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Products;

public class Product : BaseEntity
{
    [Required][MaxLength(255)] public string ProductName { get; set; } = string.Empty; // Tên sản phẩm (bắt buộc, độ dài tối đa 255 ký tự)
    [MaxLength(4000)] public string? Description { get; set; } // Mô tả sản phẩm (không bắt buộc, độ dài tối đa 4000 ký tự)
    [Required][MaxLength(50)] public string SKU { get; set; } = string.Empty; // Mã SKU sản phẩm (bắt buộc, độ dài tối đa 50 ký tự, thường dùng để quản lý kho)

    [Column(TypeName = "decimal(18, 2)")] // Định nghĩa kiểu dữ liệu decimal cho giá tiền (18 chữ số, 2 số thập phân)
    public decimal Price { get; set; } // Giá sản phẩm (bắt buộc)

    [Column(TypeName = "decimal(18, 2)")] public decimal? SalePrice { get; set; } // Giá khuyến mãi (không bắt buộc)
    public int QuantityInStock { get; set; } // Số lượng tồn kho (bắt buộc)
    [Required][MaxLength(255)] public string Slug { get; set; } = string.Empty; // Slug URL thân thiện (bắt buộc, độ dài tối đa 255 ký tự, thường dùng cho URL)

    [Column(TypeName = "decimal(18, 3)")] // Ví dụ: trọng lượng có thể có 3 chữ số thập phân
    public decimal? Weight { get; set; } // Trọng lượng sản phẩm (không bắt buộc, kiểu decimal với 3 số thập phân)

    [MaxLength(255)] public string? Dimensions { get; set; } // Kích thước sản phẩm (không bắt buộc, độ dài tối đa 255 ký tự)

    #region Navigation properties

    [Required] public Guid CategoryId { get; set; } // ID danh mục (khóa ngoại đến bảng Category, bắt buộc)
    public virtual Category Category { get; set; } = null!; // Navigation property cho danh mục (bắt buộc)
    public Guid? BrandId { get; set; } // ID thương hiệu (khóa ngoại đến bảng Brand, có thể null nếu không có thương hiệu)
    public virtual Brand? Brand { get; set; } // Navigation property cho thương hiệu (có thể null)
    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>(); // Navigation property cho hình ảnh sản phẩm (danh sách các hình ảnh của sản phẩm)
    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>(); // Navigation property cho biến thể sản phẩm (danh sách các biến thể của sản phẩm)
    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = new List<ProductAttributeValue>(); // Navigation property cho giá trị thuộc tính (quan hệ Many-to-Many, danh sách các giá trị thuộc tính của sản phẩm)
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); // Navigation property cho chi tiết đơn hàng (danh sách các chi tiết đơn hàng chứa sản phẩm này)
    public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>(); // Navigation property cho đánh giá sản phẩm (danh sách các đánh giá của sản phẩm)
    public virtual ICollection<ProductSpecification> ProductSpecifications { get; set; } = new List<ProductSpecification>(); // Navigation property cho thông số kỹ thuật sản phẩm (danh sách các thông số kỹ thuật của sản phẩm)
    public virtual ICollection<RelatedProduct> RelatedProducts { get; set; } = new List<RelatedProduct>(); // Navigation property cho sản phẩm liên quan (quan hệ tự tham chiếu Many-to-Many, danh sách các sản phẩm liên quan)
    public virtual ICollection<RelatedProduct> InverseRelatedProducts { get; set; } = new List<RelatedProduct>(); // Navigation property cho sản phẩm liên quan đảo ngược (quan hệ tự tham chiếu Many-to-Many, danh sách các sản phẩm liên quan đến sản phẩm này theo chiều ngược lại)
    public virtual ICollection<StockLevel> StockLevels { get; set; } = new List<StockLevel>(); // Navigation property cho mức tồn kho (danh sách mức tồn kho của sản phẩm ở các kho khác nhau)
    public virtual ICollection<StockMovement> StockMovements { get; set; } = new List<StockMovement>(); // Navigation property cho lịch sử nhập/xuất kho (danh sách lịch sử nhập/xuất kho của sản phẩm)
    public virtual ICollection<OrderItemReturn> OrderItemReturns { get; set; } = new List<OrderItemReturn>(); // Navigation property cho chi tiết trả hàng (danh sách chi tiết trả hàng liên quan đến sản phẩm)
    public virtual ICollection<OrderItemShipment> OrderItemShipments { get; set; } = new List<OrderItemShipment>(); // Navigation property cho chi tiết lô hàng (danh sách chi tiết lô hàng liên quan đến sản phẩm)

    #endregion
}