using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Orders;

public class ReturnStatus : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string StatusName { get; set; } = string.Empty; // Tên trạng thái trả hàng (ví dụ: "Chờ duyệt", "Đã hoàn tiền") (bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(1000)]
    public string? Description { get; set; } // Mô tả trạng thái trả hàng (không bắt buộc, độ dài tối đa 1000 ký tự)

    #region Navigation properties

    public virtual ICollection<OrderReturn> OrderReturns { get; set; } = new List<OrderReturn>(); // Navigation property cho trả hàng (danh sách các yêu cầu trả hàng có trạng thái này)

    #endregion Navigation properties
}