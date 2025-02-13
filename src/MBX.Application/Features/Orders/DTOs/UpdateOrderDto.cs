using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Orders.DTOs;

public class UpdateOrderDto
{
    [Required(ErrorMessage = "Order ID is required")]
    public Guid OrderId { get; set; }
    [Required(ErrorMessage = "Order Status ID is required")]
    public Guid OrderStatusId { get; set; }
    [MaxLength(4000)]
    public string? OrderNotes { get; set; }
    public bool IsActive { get; set; }
}