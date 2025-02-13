using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Products.DTOs;

public class CreateProductDto
{
    [Required(ErrorMessage = "Product Name is required")]
    [MaxLength(255)]
    public string ProductName { get; set; } = string.Empty;
    [MaxLength(4000)]
    public string? Description { get; set; }
    [Required(ErrorMessage = "SKU is required")]
    [MaxLength(50)]
    public string SKU { get; set; } = string.Empty;
    [Required(ErrorMessage = "Price is required")]
    [Range(0.01, double.MaxValue)]
    public decimal Price { get; set; }
    [Range(0, 100)]
    public decimal? SalePrice { get; set; }
    [Required(ErrorMessage = "Quantity In Stock is required")]
    [Range(0, int.MaxValue)]
    public int QuantityInStock { get; set; }
    [Required(ErrorMessage = "Category ID is required")]
    public Guid CategoryId { get; set; }
    public Guid? BrandId { get; set; }
    [MaxLength(255)]
    public string Slug { get; set; } = string.Empty;
    [Range(0, double.MaxValue)]
    public decimal? Weight { get; set; }
    [MaxLength(255)]
    public string? Dimensions { get; set; }
}