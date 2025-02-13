namespace MBX.Application.Features.Products.DTOs;

public class ProductImageDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public bool IsThumbnail { get; set; }
    public int? Order { get; set; }
    public bool IsActive { get; set; }
}