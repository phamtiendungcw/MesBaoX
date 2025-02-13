using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Brands.DTOs;

public class CreateBrandDto
{
    [Required(ErrorMessage = "Brand Name is required")]
    [MaxLength(255)]
    public string BrandName { get; set; } = string.Empty;
    [MaxLength(1000)]
    public string? Description { get; set; }
    [MaxLength(255)]
    public string? LogoUrl { get; set; }
    [Required(ErrorMessage = "Slug is required")]
    [MaxLength(255)]
    public string Slug { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}