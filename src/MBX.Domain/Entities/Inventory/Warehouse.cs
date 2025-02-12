using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Inventory;

public class Warehouse : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string WarehouseName { get; set; } = string.Empty; // Tên kho hàng (ví dụ: "Kho Hà Nội", "Kho Hồ Chí Minh") (bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(255)]
    public string? Address { get; set; } // Địa chỉ kho (không bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(255)]
    public string? ContactPerson { get; set; } // Người liên hệ kho (không bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(20)]
    public string? PhoneNumber { get; set; } // Số điện thoại liên hệ kho (không bắt buộc, độ dài tối đa 20 ký tự)

    #region Navigation properties

    public virtual ICollection<StockLevel> StockLevels { get; set; } = new List<StockLevel>(); // Navigation property cho mức tồn kho (danh sách mức tồn kho tại kho này)
    public virtual ICollection<StockMovement> StockMovements { get; set; } = new List<StockMovement>(); // Navigation property cho lịch sử nhập/xuất kho (danh sách lịch sử nhập/xuất kho tại kho này)

    #endregion Navigation properties
}