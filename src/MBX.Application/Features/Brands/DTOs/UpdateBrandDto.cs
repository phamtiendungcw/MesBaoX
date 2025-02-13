using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Brands.DTOs;

public class UpdateBrandDto
{
    [Required(ErrorMessage = "Brand ID is required")]
    public Guid BrandId { get; set; }
    [MaxLength(255)]
    public string? BrandName { get; set; }
    [MaxLength(1000)]
    public string? Description { get; set; }
    [MaxLength(255)]
    public string? LogoUrl { get; set; }
    [MaxLength(255)]
    public string? Slug { get; set; }
    public bool IsActive { get; set; }
}