using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Categories.DTOs;

public class UpdateCategoryDto
{
    [Required(ErrorMessage = "Category ID is required")]
    public Guid CategoryId { get; set; }
    [MaxLength(255)]
    public string? CategoryName { get; set; }
    [MaxLength(1000)]
    public string? Description { get; set; }
    public Guid? ParentCategoryId { get; set; }
    [MaxLength(255)]
    public string? Slug { get; set; }
    public bool IsActive { get; set; }
}