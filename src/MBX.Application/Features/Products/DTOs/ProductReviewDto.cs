namespace MBX.Application.Features.Products.DTOs;

public class ProductReviewDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid? CustomerId { get; set; }
    public int Rating { get; set; }
    public string? Comment { get; set; }
    public bool IsApproved { get; set; }
    public bool IsActive { get; set; }
}