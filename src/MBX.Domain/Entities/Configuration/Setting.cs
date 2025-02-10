using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Configuration;

public class Setting : BaseEntity
{
    [Required][MaxLength(255)] public string SettingKey { get; set; } = string.Empty; // Khóa cài đặt (ví dụ: "WebsiteName", "DefaultCurrency", "SMTPHost") (bắt buộc, độ dài tối đa 255 ký tự, duy nhất trong hệ thống)
    public string? SettingValue { get; set; } // Giá trị cài đặt (không bắt buộc, kiểu dữ liệu string, giá trị có thể khác nhau tùy theo SettingKey)
    [MaxLength(1000)] public string? Description { get; set; } // Mô tả cài đặt (không bắt buộc, độ dài tối đa 1000 ký tự, giải thích mục đích của cài đặt)
    [MaxLength(255)] public string? SettingGroup { get; set; } // Nhóm cài đặt (ví dụ: "General", "Email", "Payment") (không bắt buộc, độ dài tối đa 255 ký tự, dùng để nhóm các cài đặt liên quan)
}