using MBX.Domain.Entities.Users;

using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Customers;

public class CustomerNote : BaseEntity
{
    [Required] public Guid CustomerId { get; set; } // ID khách hàng (khóa ngoại đến bảng Customer, bắt buộc)
    public virtual Customer Customer { get; set; } = null!; // Navigation property cho khách hàng (bắt buộc)
    [Required] public Guid UserId { get; set; } // ID người dùng (nhân viên tạo ghi chú) (khóa ngoại đến bảng User, bắt buộc)
    public virtual User User { get; set; } = null!; // Navigation property cho người dùng (bắt buộc)
    [Required][MaxLength(4000)] public string NoteContent { get; set; } = string.Empty; // Nội dung ghi chú (bắt buộc, độ dài tối đa 4000 ký tự)
}