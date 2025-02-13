using MBX.Application.Features.Products.DTOs;

namespace MBX.Application.Features.Brands.DTOs;

public class BrandDetailsDto : BrandDto
{
    public List<ProductDto>? Products { get; set; }
}