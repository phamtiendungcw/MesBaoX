namespace MBX.Application.Features.Brands.DTOs;

public class BrandDto
{
    public Guid Id { get; set; }
    public string BrandName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? LogoUrl { get; set; }
    public string Slug { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}