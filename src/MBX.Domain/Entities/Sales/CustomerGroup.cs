using MBX.Domain.Common;
using MBX.Domain.Entities.Core;

namespace MBX.Domain.Entities.Sales;

public class CustomerGroup : BaseEntity
{
    public Guid CompanyId { get; set; } // ID công ty
    public Company Company { get; set; } = null!; // Công ty mà nhóm khách hàng thuộc về (Navigation)
    public string Name { get; set; } = string.Empty; // Tên nhóm khách hàng
    public string? Description { get; set; } // Mô tả nhóm khách hàng (tùy chọn)
    public decimal? DiscountPercentage { get; set; } // Phần trăm chiết khấu mặc định cho nhóm (tùy chọn)
    public Guid? ParentGroupId { get; set; } // ID nhóm cha (tùy chọn, cho phân cấp nhóm)
    public CustomerGroup? ParentGroup { get; set; } // Nhóm cha (Navigation, cho phân cấp nhóm)
    public ICollection<Customer> Customers { get; set; } = new List<Customer>(); // Danh sách khách hàng thuộc nhóm (Navigation)
}