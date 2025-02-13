using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Orders.DTOs;

public class ShipmentDto
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Order ID is required")]
    public Guid OrderId { get; set; }
    [MaxLength(255)]
    public string? ShippingCarrier { get; set; }
    [MaxLength(255)]
    public string? TrackingNumber { get; set; }
    public DateTime? ShipmentDate { get; set; }
    public DateTime? EstimatedDeliveryDate { get; set; }
    public DateTime? ActualDeliveryDate { get; set; }
    [MaxLength(255)]
    public string? ShipmentStatus { get; set; }
    public bool IsActive { get; set; }
}