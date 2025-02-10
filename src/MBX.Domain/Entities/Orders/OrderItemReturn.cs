using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Orders;

public class OrderItemReturn : BaseEntity
{
    [Required] public Guid OrderReturnId { get; set; } // ID yêu cầu trả hàng (khóa ngoại đến bảng OrderReturn, bắt buộc)
    public virtual OrderReturn OrderReturn { get; set; } = null!; // Navigation property cho yêu cầu trả hàng (bắt buộc)
    [Required] public Guid OrderItemId { get; set; } // ID chi tiết đơn hàng gốc (khóa ngoại đến bảng OrderItem, bắt buộc)
    public virtual OrderItem OrderItem { get; set; } = null!; // Navigation property cho chi tiết đơn hàng gốc (bắt buộc)
    public int QuantityReturned { get; set; } // Số lượng sản phẩm trả lại (bắt buộc)
}