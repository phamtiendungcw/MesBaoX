namespace MBX.Domain.Common;

public abstract class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid(); // ID duy nhất
    public DateTime CreateAt { get; set; } = DateTime.UtcNow; // Thời điểm tạo (mặc định UTC now)
    public DateTime? UpdatedAt { get; set; } // Thời điểm cập nhật (tùy chọn)
    public Guid? CreatedByUserId { get; set; } // ID người tạo (tùy chọn)
    public Guid? UpdatedByUserId { get; set; } // ID người cập nhật (tùy chọn)
    public bool IsActive { get; set; } = true; // Trạng thái hoạt động (mặc định true)
    public bool IsDeleted { get; set; } = false; // Trạng thái xóa (mặc định false - xóa mềm)
}