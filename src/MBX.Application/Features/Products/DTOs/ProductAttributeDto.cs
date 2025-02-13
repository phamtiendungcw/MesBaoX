namespace MBX.Application.Features.Products.DTOs;

public class ProductAttributeDto
{
    public Guid Id { get; set; }
    public string AttributeName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}