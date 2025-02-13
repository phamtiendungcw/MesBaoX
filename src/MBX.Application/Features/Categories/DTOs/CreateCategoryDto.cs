using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Categories.DTOs;

public class CreateCategoryDto
{
    [Required(ErrorMessage = "Category Name is required")]
    [MaxLength(255)]
    public string CategoryName { get; set; } = string.Empty;
    [MaxLength(1000)]
    public string? Description { get; set; }
    public Guid? ParentCategoryId { get; set; }
    [Required(ErrorMessage = "Slug is required")]
    [MaxLength(255)]
    public string Slug { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}