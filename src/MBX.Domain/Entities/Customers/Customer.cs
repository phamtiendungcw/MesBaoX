using MBX.Domain.Entities.Orders;
using MBX.Domain.Entities.Products;

using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Customers;

public class Customer : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string FirstName { get; set; } = string.Empty; // Tên khách hàng (bắt buộc, độ dài tối đa 255 ký tự)

    [Required]
    [MaxLength(255)]
    public string LastName { get; set; } = string.Empty; // Họ khách hàng (bắt buộc, độ dài tối đa 255 ký tự)

    [Required]
    [MaxLength(255)]
    [EmailAddress] // DataAnnotation để validate email format
    public string Email { get; set; } = string.Empty; // Email khách hàng (bắt buộc, độ dài tối đa 255 ký tự, định dạng email)

    [MaxLength(20)]
    public string? PhoneNumber { get; set; } // Số điện thoại khách hàng (không bắt buộc, độ dài tối đa 20 ký tự)

    [Required]
    [MaxLength(255)]
    public string PasswordHash { get; set; } = string.Empty; // Hash mật khẩu (bắt buộc, độ dài tối đa 255 ký tự, dùng để lưu mật khẩu đã hash)

    [Required]
    [MaxLength(255)]
    public string PasswordSalt { get; set; } = string.Empty; // Salt mật khẩu (bắt buộc, độ dài tối đa 255 ký tự, dùng để tăng cường bảo mật khi hash mật khẩu)

    public DateTime? DateOfBirth { get; set; } // Ngày sinh (không bắt buộc)

    [MaxLength(20)]
    public string? Gender { get; set; } // Giới tính (không bắt buộc, độ dài tối đa 20 ký tự)

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>(); // Danh sách các địa chỉ của khách hàng
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>(); // Danh sách các đơn hàng của khách hàng
    public virtual ICollection<CustomerLoyaltyPoint> LoyaltyPoints { get; set; } = new List<CustomerLoyaltyPoint>(); // Danh sách các giao dịch điểm tích lũy của khách hàng
    public virtual ICollection<CustomerNote> CustomerNotes { get; set; } = new List<CustomerNote>(); // Danh sách các ghi chú về khách hàng
    public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>(); // Danh sách các đánh giá sản phẩm của khách hàng
    public virtual ICollection<CustomerGroup> CustomerGroups { get; set; } = new List<CustomerGroup>(); // Quan hệ Many-to-Many, danh sách các nhóm khách hàng mà khách hàng thuộc về
}