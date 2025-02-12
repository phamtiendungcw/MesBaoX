using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Content;

public class MenuItem : BaseEntity
{
    [Required]
    public Guid MenuId { get; set; } // ID menu cha (khóa ngoại đến bảng Menu, bắt buộc)

    public virtual Menu Menu { get; set; } = null!; // Navigation property cho menu cha (bắt buộc)

    [Required]
    [MaxLength(255)]
    public string MenuItemName { get; set; } = string.Empty; // Tên mục menu (bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(255)]
    public string? Url { get; set; } // URL liên kết (không bắt buộc, độ dài tối đa 255 ký tự, có thể là URL bên ngoài hoặc URL nội bộ)

    #region Navigation properties

    public Guid? PageId { get; set; } // ID trang nội dung liên kết (khóa ngoại đến bảng Page, có thể null nếu mục menu không liên kết đến trang CMS)
    public virtual Page? Page { get; set; } // Navigation property cho trang nội dung (có thể null)
    public int? Order { get; set; } // Thứ tự hiển thị mục menu (không bắt buộc, dùng để sắp xếp các mục menu)
    public Guid? ParentMenuItemId { get; set; } // ID mục menu cha (khóa ngoại đến bảng MenuItem, có thể null nếu là mục menu cấp cao nhất)
    public virtual MenuItem? ParentMenuItem { get; set; } // Navigation property cho mục menu cha (có thể null, hỗ trợ menu đa cấp)
    public virtual ICollection<MenuItem> ChildMenuItems { get; set; } = new List<MenuItem>(); // Navigation property cho mục menu con (danh sách các mục menu con thuộc mục menu này, hỗ trợ menu đa cấp)

    #endregion Navigation properties
}