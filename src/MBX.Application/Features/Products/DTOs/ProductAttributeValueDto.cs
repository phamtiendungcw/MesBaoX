namespace MBX.Application.Features.Products.DTOs;

public class ProductAttributeValueDto
{
    public Guid Id { get; set; }
    public Guid ProductAttributeId { get; set; }
    public string Value { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}