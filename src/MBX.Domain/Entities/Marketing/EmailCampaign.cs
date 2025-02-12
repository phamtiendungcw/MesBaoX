using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Marketing;

public class EmailCampaign : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string CampaignName { get; set; } = string.Empty; // Tên chiến dịch email (bắt buộc, độ dài tối đa 255 ký tự)

    [Required]
    [MaxLength(255)]
    public string Subject { get; set; } = string.Empty; // Tiêu đề email (bắt buộc, độ dài tối đa 255 ký tự)

    public string? Body { get; set; } // Nội dung email (không bắt buộc, cho phép HTML hoặc Text)

    [MaxLength(255)]
    public string? Segment { get; set; } // Phân khúc khách hàng mục tiêu (không bắt buộc, độ dài tối đa 255 ký tự, ví dụ: "Khách hàng VIP", "Khách hàng mới")

    public DateTime? SendDate { get; set; } // Ngày gửi email (không bắt buộc)

    [MaxLength(50)]
    public string? Status { get; set; } // Trạng thái chiến dịch (ví dụ: "Pending", "Sending", "Sent", "Completed") (không bắt buộc, độ dài tối đa 50 ký tự)
}