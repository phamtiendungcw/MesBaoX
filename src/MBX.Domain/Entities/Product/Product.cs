using MBX.Domain.Common;
using MBX.Domain.Entities.Order;

namespace MBX.Domain.Entities.Product
{
    public class Product : BaseEntity
    {
        public Guid CompanyId { get; set; } // ID công ty
        public Core.Company Company { get; set; } = null!; // Công ty mà sản phẩm thuộc về (Navigation)
        public string Name { get; set; } = string.Empty; // Tên sản phẩm - Non-nullable, default to empty string
        public string? Description { get; set; } // Mô tả sản phẩm (tùy chọn) - Nullable
        public string SKU { get; set; } = string.Empty; // Mã sản phẩm (Stock Keeping Unit) - Non-nullable, default to empty string
        public decimal Price { get; set; } // Giá bán sản phẩm
        public decimal? DiscountPrice { get; set; } // Giá khuyến mãi (tùy chọn) - Nullable
        public int StockQuantity { get; set; } // Số lượng tồn kho
        public string? UnitOfMeasure { get; set; } // Đơn vị đo lường (tùy chọn) - Nullable
        public string? Brand { get; set; } // Thương hiệu sản phẩm (tùy chọn) - Nullable
        public string? Model { get; set; } // Model sản phẩm (tùy chọn) - Nullable
        public decimal CostPrice { get; set; } // Giá vốn sản phẩm
        public int ReorderLevel { get; set; } // Mức tái đặt hàng
        public string? Barcode { get; set; } // Mã vạch sản phẩm (tùy chọn) - Nullable
        public string? Manufacturer { get; set; } // Nhà sản xuất (tùy chọn) - Nullable
        public string? Size { get; set; } // Kích thước sản phẩm (tùy chọn) - Nullable
        public string? Color { get; set; } // Màu sắc sản phẩm (tùy chọn) - Nullable
        public decimal? Weight { get; set; } // Trọng lượng sản phẩm (tùy chọn) - Nullable
        public string? Dimensions { get; set; } // Kích thước đóng gói sản phẩm (tùy chọn) - Nullable
        public string ProductType { get; set; } = string.Empty; // Loại sản phẩm - Non-nullable, default to empty string (Consider enum default if applicable)
        public string? TaxCode { get; set; } // Mã thuế sản phẩm (tùy chọn) - Nullable
        public ICollection<Category> Categories { get; set; } = new List<Category>(); // Danh sách Category (Navigation)
        public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>(); // Danh sách Images (Navigation)
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>(); // Danh sách OrderDetails (Navigation)
        public ICollection<Inventory.Inventory> Inventories { get; set; } = new List<Inventory.Inventory>(); // Danh sách Inventories (Navigation)
        public Guid? SupplierId { get; set; } // ID nhà cung cấp (tùy chọn)
        public Supplier? Supplier { get; set; } // Nhà cung cấp (Navigation)
    }
}