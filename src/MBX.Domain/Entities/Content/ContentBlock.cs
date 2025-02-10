using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Content;

public class ContentBlock : BaseEntity
{
    [Required][MaxLength(255)] public string BlockName { get; set; } = string.Empty; // Tên khối nội dung (bắt buộc, độ dài tối đa 255 ký tự)
    public string? BlockContent { get; set; } // Nội dung khối (không bắt buộc, cho phép HTML hoặc Markdown)
}