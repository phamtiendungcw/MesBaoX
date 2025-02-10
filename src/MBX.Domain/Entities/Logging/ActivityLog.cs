using MBX.Domain.Entities.Users;

using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Logging;

public class ActivityLog : BaseEntity
{
    public Guid? UserId { get; set; } // ID người dùng thực hiện hành động (khóa ngoại đến bảng User, có thể null nếu hành động không liên quan đến người dùng cụ thể, ví dụ: hệ thống tự động thực hiện)
    public virtual User? User { get; set; } // Navigation property cho người dùng (có thể null)
    [Required][MaxLength(50)] public string ActivityType { get; set; } = string.Empty; // Loại hành động (ví dụ: "Login", "AddProduct", "UpdateOrder") (bắt buộc, độ dài tối đa 50 ký tự)
    [MaxLength(4000)] public string? ActivityDescription { get; set; } // Mô tả chi tiết hành động (không bắt buộc, độ dài tối đa 4000 ký tự, chi tiết cụ thể về hành động)
    public DateTime Timestamp { get; set; } = DateTime.UtcNow; // Thời điểm hành động xảy ra (mặc định UTC now)
    [MaxLength(50)] public string? IpAddress { get; set; } // Địa chỉ IP của người dùng thực hiện hành động (không bắt buộc, độ dài tối đa 50 ký tự, có thể dùng để theo dõi nguồn gốc hành động)
    [MaxLength(255)] public string? EntityName { get; set; } // Tên entity liên quan đến hành động (ví dụ: "Product", "Order", "Customer") (không bắt buộc, độ dài tối đa 255 ký tự, xác định entity nào bị tác động)
    public Guid? EntityId { get; set; } // ID entity liên quan đến hành động (không bắt buộc, có thể null nếu hành động không liên quan đến entity cụ thể, ví dụ: "Login")
}