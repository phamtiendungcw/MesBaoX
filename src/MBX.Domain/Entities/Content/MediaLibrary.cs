using MBX.Domain.Entities.Users;

using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Content;

public class MediaLibrary : BaseEntity
{
    [Required][MaxLength(50)] public string MediaType { get; set; } = string.Empty; // Loại media (ví dụ: "Image", "Video", "Document") (bắt buộc, độ dài tối đa 50 ký tự)
    [Required][MaxLength(255)] public string FileName { get; set; } = string.Empty; // Tên file (bắt buộc, độ dài tối đa 255 ký tự)
    [Required][MaxLength(255)] public string FilePath { get; set; } = string.Empty; // Đường dẫn file (bắt buộc, độ dài tối đa 255 ký tự, có thể là đường dẫn tương đối hoặc tuyệt đối)
    public long? FileSize { get; set; } // Kích thước file (không bắt buộc, tính bằng byte)
    public Guid? UploadedByUserId { get; set; } // ID người dùng tải lên (khóa ngoại đến bảng User, có thể null nếu tải lên bởi hệ thống)
    public virtual User? UploadedByUser { get; set; } // Navigation property cho người dùng tải lên (có thể null)
    public DateTime UploadedDate { get; set; } = DateTime.UtcNow; // Ngày tải lên (mặc định UTC now)
}