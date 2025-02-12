using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Orders;

public class OrderReturn : BaseEntity
{
    [Required]
    public Guid OrderId { get; set; } // ID đơn hàng gốc (khóa ngoại đến bảng Order, bắt buộc)

    public virtual Order Order { get; set; } = null!; // Navigation property cho đơn hàng gốc (bắt buộc)
    public DateTime ReturnDate { get; set; } = DateTime.UtcNow; // Ngày yêu cầu trả hàng (mặc định UTC now)

    [Required]
    [MaxLength(4000)]
    public string ReturnReason { get; set; } = string.Empty; // Lý do trả hàng (bắt buộc, độ dài tối đa 4000 ký tự)

    [Required]
    public Guid ReturnStatusId { get; set; } // ID trạng thái trả hàng (khóa ngoại đến bảng ReturnStatus, bắt buộc)

    public virtual ReturnStatus ReturnStatus { get; set; } = null!; // Navigation property cho trạng thái trả hàng (bắt buộc)

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RefundAmount { get; set; } // Số tiền hoàn trả (không bắt buộc, kiểu decimal với 2 số thập phân)

    [MaxLength(4000)]
    public string? ReturnNotes { get; set; } // Ghi chú trả hàng (không bắt buộc, độ dài tối đa 4000 ký tự)

    #region Navigation properties

    public virtual ICollection<OrderItemReturn> OrderItemReturns { get; set; } = new List<OrderItemReturn>(); // Navigation property cho chi tiết trả hàng (danh sách chi tiết trả hàng của yêu cầu trả hàng này)

    #endregion Navigation properties
}