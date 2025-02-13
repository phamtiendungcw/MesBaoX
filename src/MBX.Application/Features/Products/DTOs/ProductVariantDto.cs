namespace MBX.Application.Features.Products.DTOs;

public class ProductVariantDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public string SKU { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal? SalePrice { get; set; }
    public int QuantityInStock { get; set; }
    public string? VariantName { get; set; }
    public string? ImageUrl { get; set; }
    public bool IsActive { get; set; }
}