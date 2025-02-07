using MBX.Domain.Common;

namespace MBX.Domain.Entities.Order;

public class OrderDetail : BaseEntity
{
    public int Quantity { get; set; } // Số lượng sản phẩm
    public decimal UnitPrice { get; set; } // Đơn giá sản phẩm
    public decimal DiscountAmount { get; set; } // Chiết khấu dòng hàng
    public decimal TaxAmount { get; set; } // Thuế dòng hàng
    public decimal LineTotal => Quantity * UnitPrice - DiscountAmount + TaxAmount; // Tổng tiền dòng (tính toán)
    public Guid OrderId { get; set; } // ID đơn hàng
    public Order Order { get; set; } = null!; // Đơn hàng mà OrderDetail thuộc về (Navigation)
    public Guid ProductId { get; set; } // ID sản phẩm
    public Product.Product Product { get; set; } = null!; // Sản phẩm (Navigation)
}