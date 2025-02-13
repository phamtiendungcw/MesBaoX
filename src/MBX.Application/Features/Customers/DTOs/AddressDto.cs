using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Customers.DTOs;

public class AddressDto
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    [Required(ErrorMessage = "Address Line 1 is required")]
    [MaxLength(255)]
    public string AddressLine1 { get; set; } = string.Empty;
    [MaxLength(255)]
    public string? AddressLine2 { get; set; }
    [Required(ErrorMessage = "City is required")]
    [MaxLength(100)]
    public string City { get; set; } = string.Empty;
    [Required(ErrorMessage = "State/Province is required")]
    [MaxLength(100)]
    public string StateProvince { get; set; } = string.Empty;
    [MaxLength(20)]
    public string? ZipCode { get; set; }
    [Required(ErrorMessage = "Country is required")]
    [MaxLength(100)]
    public string Country { get; set; } = string.Empty;
    public bool IsDefaultShippingAddress { get; set; }
    public bool IsDefaultBillingAddress { get; set; }
    public bool IsActive { get; set; }
}