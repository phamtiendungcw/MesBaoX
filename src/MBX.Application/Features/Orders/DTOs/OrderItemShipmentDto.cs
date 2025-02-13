using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Orders.DTOs;

public class OrderItemShipmentDto
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Shipment ID is required")]
    public Guid ShipmentId { get; set; }
    [Required(ErrorMessage = "Order Item ID is required")]
    public Guid OrderItemId { get; set; }
    [Required(ErrorMessage = "Quantity Shipped is required")]
    [Range(1, int.MaxValue)]
    public int QuantityShipped { get; set; }
    public bool IsActive { get; set; }
}