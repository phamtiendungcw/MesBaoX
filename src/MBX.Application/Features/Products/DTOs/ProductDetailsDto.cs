using MBX.Application.Features.Brands.DTOs;
using MBX.Application.Features.Categories.DTOs;

namespace MBX.Application.Features.Products.DTOs;

public class ProductDetailsDto : ProductDto
{
    public Guid CategoryId { get; set; }
    public CategoryDto? Category { get; set; }
    public Guid? BrandId { get; set; }
    public BrandDto? Brand { get; set; }
    public List<ProductImageDto>? ProductImages { get; set; }
    public List<ProductVariantDto>? ProductVariants { get; set; }
    public List<ProductReviewDto>? ProductReviews { get; set; }
    public List<ProductSpecificationDto>? ProductSpecifications { get; set; }
}