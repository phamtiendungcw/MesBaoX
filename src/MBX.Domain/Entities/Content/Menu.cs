using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Content;

public class Menu : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string MenuName { get; set; } = string.Empty; // Tên menu (ví dụ: "Menu chính", "Menu chân trang") (bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(1000)]
    public string? Description { get; set; } // Mô tả menu (không bắt buộc, độ dài tối đa 1000 ký tự)

    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); // Navigation property cho mục menu (danh sách các mục menu thuộc menu này)
}