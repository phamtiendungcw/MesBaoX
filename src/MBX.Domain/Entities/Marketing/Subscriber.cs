using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Marketing;

public class Subscriber : BaseEntity
{
    [Required]
    [MaxLength(255)]
    [EmailAddress] // DataAnnotation để validate email format
    public string Email { get; set; } = string.Empty; // Email người đăng ký (bắt buộc, độ dài tối đa 255 ký tự, định dạng email, duy nhất trong hệ thống)

    public DateTime SubscriptionDate { get; set; } = DateTime.UtcNow; // Ngày đăng ký nhận tin (mặc định UTC now)
}