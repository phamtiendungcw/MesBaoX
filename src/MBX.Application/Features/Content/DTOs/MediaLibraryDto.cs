namespace MBX.Application.Features.Content.DTOs;

public class MediaLibraryDto
{
    public Guid Id { get; set; }
    public string MediaType { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
    public string FilePath { get; set; } = string.Empty;
    public long? FileSize { get; set; }
    public Guid? UploadedByUserId { get; set; }
    public DateTime UploadedDate { get; set; }
    public bool IsActive { get; set; }
}