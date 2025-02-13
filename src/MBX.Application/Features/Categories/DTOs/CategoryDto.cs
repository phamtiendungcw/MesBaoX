namespace MBX.Application.Features.Categories.DTOs;

public class CategoryDto
{
    public Guid Id { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Guid? ParentCategoryId { get; set; }
    public string Slug { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}