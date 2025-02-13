using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Orders.DTOs;

public class CreateOrderDto
{
    [Required(ErrorMessage = "Customer ID is required")]
    public Guid CustomerId { get; set; }
    [Required(ErrorMessage = "Shipping Address ID is required")]
    public Guid ShippingAddressId { get; set; }
    [Required(ErrorMessage = "Billing Address ID is required")]
    public Guid BillingAddressId { get; set; }
    public Guid? PaymentMethodId { get; set; }
    public Guid? ShippingMethodId { get; set; }
    [MaxLength(4000)]
    public string? OrderNotes { get; set; }
    public bool IsActive { get; set; }
}