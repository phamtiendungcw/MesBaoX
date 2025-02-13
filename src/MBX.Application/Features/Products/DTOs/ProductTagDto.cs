namespace MBX.Application.Features.Products.DTOs;

public class ProductTagDto
{
    public Guid Id { get; set; }
    public string TagName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}