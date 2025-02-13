namespace MBX.Application.Features.Orders.DTOs;

public class OrderItemDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public Guid? ProductVariantId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string? ProductName { get; set; }
    public bool IsActive { get; set; }
}