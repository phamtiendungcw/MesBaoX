using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Orders.DTOs;

public class ShippingMethodDto
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Method Name is required")]
    [MaxLength(255)]
    public string MethodName { get; set; } = string.Empty;
    [MaxLength(1000)]
    public string? Description { get; set; }
    [Required(ErrorMessage = "Cost is required")]
    [Range(0.01, double.MaxValue)]
    public decimal Cost { get; set; }
    [MaxLength(255)]
    public string? EstimatedDeliveryTime { get; set; }
    public bool IsActive { get; set; }
}