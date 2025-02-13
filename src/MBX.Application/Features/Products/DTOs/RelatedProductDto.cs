namespace MBX.Application.Features.Products.DTOs;

public class RelatedProductDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid RelatedToProductId { get; set; }
    public string? RelationType { get; set; }
    public bool IsActive { get; set; }
}