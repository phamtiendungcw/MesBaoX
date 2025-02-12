using MBX.Domain.Entities.Inventory;
using MBX.Domain.Entities.Orders;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Products;

public class ProductVariant : BaseEntity
{
    [Required]
    public Guid ProductId { get; set; } // ID sản phẩm gốc (khóa ngoại đến bảng Product, bắt buộc)

    public virtual Product Product { get; set; } = null!; // Navigation property cho sản phẩm gốc (bắt buộc)

    [Required]
    [MaxLength(50)]
    public string SKU { get; set; } = string.Empty; // Mã SKU biến thể (bắt buộc, độ dài tối đa 50 ký tự, duy nhất trong biến thể sản phẩm)

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; } // Giá biến thể (bắt buộc)

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? SalePrice { get; set; } // Giá khuyến mãi biến thể (không bắt buộc)

    public int QuantityInStock { get; set; } // Số lượng tồn kho biến thể (bắt buộc)

    [MaxLength(255)]
    public string? VariantName { get; set; } // Tên biến thể (không bắt buộc, có thể tự động tạo từ thuộc tính)

    [MaxLength(255)]
    public string? ImageUrl { get; set; } // URL hình ảnh biến thể (không bắt buộc, nếu có ảnh riêng cho biến thể)

    #region Navigation properties

    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = new List<ProductAttributeValue>(); // Navigation property cho giá trị thuộc tính (quan hệ Many-to-Many, danh sách các giá trị thuộc tính của biến thể)
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); // Navigation property cho chi tiết đơn hàng (danh sách các chi tiết đơn hàng chứa biến thể này)
    public virtual ICollection<StockLevel> StockLevels { get; set; } = new List<StockLevel>(); // Navigation property cho mức tồn kho (danh sách mức tồn kho của biến thể ở các kho khác nhau)
    public virtual ICollection<StockMovement> StockMovements { get; set; } = new List<StockMovement>(); // Navigation property cho lịch sử nhập/xuất kho (danh sách lịch sử nhập/xuất kho của biến thể)
    public virtual ICollection<OrderItemReturn> OrderItemReturns { get; set; } = new List<OrderItemReturn>(); // Navigation property cho chi tiết trả hàng (danh sách chi tiết trả hàng liên quan đến biến thể)
    public virtual ICollection<OrderItemShipment> OrderItemShipments { get; set; } = new List<OrderItemShipment>(); // Navigation property cho chi tiết lô hàng (danh sách chi tiết lô hàng liên quan đến biến thể)

    #endregion Navigation properties
}