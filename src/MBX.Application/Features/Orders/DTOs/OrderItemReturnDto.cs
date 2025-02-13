using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Orders.DTOs;

public class OrderItemReturnDto
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Order Return ID is required")]
    public Guid OrderReturnId { get; set; }
    [Required(ErrorMessage = "Order Item ID is required")]
    public Guid OrderItemId { get; set; }
    [Required(ErrorMessage = "Quantity Returned is required")]
    [Range(1, int.MaxValue)]
    public int QuantityReturned { get; set; }
    public bool IsActive { get; set; }
}