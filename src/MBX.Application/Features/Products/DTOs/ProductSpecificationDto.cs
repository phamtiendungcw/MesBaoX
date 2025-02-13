namespace MBX.Application.Features.Products.DTOs;

public class ProductSpecificationDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public string SpecificationName { get; set; } = string.Empty;
    public string SpecificationValue { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}