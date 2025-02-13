using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Products.DTOs;

public class UpdateProductDto
{
    [Required(ErrorMessage = "Product ID is required")]
    public Guid ProductId { get; set; }
    [MaxLength(255)]
    public string? ProductName { get; set; }
    [MaxLength(4000)]
    public string? Description { get; set; }
    [MaxLength(50)]
    public string? SKU { get; set; }
    [Range(0.01, double.MaxValue)]
    public decimal? Price { get; set; }
    [Range(0, 100)]
    public decimal? SalePrice { get; set; }
    [Range(0, int.MaxValue)]
    public int? QuantityInStock { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? BrandId { get; set; }
    [MaxLength(255)]
    public string? Slug { get; set; }
    [Range(0, double.MaxValue)]
    public decimal? Weight { get; set; }
    [MaxLength(255)]
    public string? Dimensions { get; set; }
    public bool IsActive { get; set; }
}