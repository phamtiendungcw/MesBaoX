using MBX.Domain.Common;

namespace MBX.Domain.Entities.ProjectManagement;

public class ExpenseClaim : BaseEntity
{
    public Guid ProjectId { get; set; } // ID dự án
    public Project Project { get; set; } = null!; // Dự án mà ExpenseClaim thuộc về (Navigation)
    public Guid UserId { get; set; } // ID người dùng
    public Core.User User { get; set; } = null!; // Người dùng (Navigation)
    public DateTime ClaimDate { get; set; } // Ngày yêu cầu thanh toán
    public decimal Amount { get; set; } // Số tiền yêu cầu
    public string CurrencyCode { get; set; } = string.Empty; // Mã đơn vị tiền tệ - Non-nullable, default to empty string
    public string ExpenseCategory { get; set; } = string.Empty; // Danh mục chi phí - Non-nullable, default to empty string (Consider enum default if applicable)
    public string? Description { get; set; } // Mô tả chi phí (tùy chọn) - Nullable
    public string ClaimStatus { get; set; } = string.Empty; // Trạng thái yêu cầu - Non-nullable, default to empty string (Consider enum default if applicable)
    public string? ReceiptImageUrl { get; set; } // URL hình ảnh hóa đơn (tùy chọn) - Nullable
    public string? Notes { get; set; } // Ghi chú ExpenseClaim (tùy chọn) - Nullable
    public string? CustomFields { get; set; } // Trường tùy chỉnh (JSON) - Nullable
}