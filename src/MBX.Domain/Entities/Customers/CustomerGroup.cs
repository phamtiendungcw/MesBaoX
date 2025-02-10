using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Customers;

public class CustomerGroup : BaseEntity
{
    [Required][MaxLength(255)] public string GroupName { get; set; } = string.Empty; // Tên nhóm khách hàng (ví dụ: "VIP", "Sỉ", "Lẻ") (bắt buộc, độ dài tối đa 255 ký tự)
    [MaxLength(1000)] public string? Description { get; set; } // Mô tả nhóm khách hàng (không bắt buộc, độ dài tối đa 1000 ký tự)

    [Column(TypeName = "decimal(5, 2)")] // Ví dụ: Giảm giá phần trăm (tối đa 99.99%)
    public decimal? DiscountPercentage { get; set; } // Phần trăm giảm giá mặc định cho nhóm (không bắt buộc, kiểu decimal với 2 số thập phân)

    #region Navigation properties

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>(); // Navigation property cho khách hàng (quan hệ Many-to-Many, danh sách các khách hàng thuộc nhóm này)

    #endregion
}