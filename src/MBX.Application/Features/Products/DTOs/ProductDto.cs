namespace MBX.Application.Features.Products.DTOs
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string SKU { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public int QuantityInStock { get; set; }
        public string Slug { get; set; } = string.Empty;
        public decimal? Weight { get; set; }
        public string? Dimensions { get; set; }
        public bool IsActive { get; set; }
    }
}
