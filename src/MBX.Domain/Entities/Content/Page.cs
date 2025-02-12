using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Content;

public class Page : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string PageTitle { get; set; } = string.Empty; // Tiêu đề trang (bắt buộc, độ dài tối đa 255 ký tự)

    public string? PageContent { get; set; } // Nội dung trang (không bắt buộc, cho phép HTML hoặc Markdown)

    [Required]
    [MaxLength(255)]
    public string Slug { get; set; } = string.Empty; // Slug trang (bắt buộc, độ dài tối đa 255 ký tự, thường dùng cho URL)

    #region Navigation properties

    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); // Danh sách các mục menu liên kết đến trang này

    #endregion Navigation properties
}