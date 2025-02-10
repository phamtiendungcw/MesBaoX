namespace MBX.Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Thời điểm tạo (mặc định UTC now)
    public DateTime? UpdatedAt { get; set; } // Thời điểm cập nhật
    public Guid? CreatedByUserId { get; set; } // ID người tạo
    public Guid? UpdatedByUserId { get; set; } // ID người cập nhật
    public bool IsActive { get; set; } = true; // Trạng thái hoạt động (mặc định true)
    public bool IsDeleted { get; set; } = false; // Trạng thái xóa (mặc định false - xóa mềm)
}