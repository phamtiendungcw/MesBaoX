using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Customers.DTOs;

public class UpdateCustomerDto
{
    [Required(ErrorMessage = "Customer ID is required")]
    public Guid CustomerId { get; set; }
    [MaxLength(255)]
    public string? FirstName { get; set; }
    [MaxLength(255)]
    public string? LastName { get; set; }
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [MaxLength(255)]
    public string? Email { get; set; }
    [MaxLength(20)]
    public string? PhoneNumber { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Gender { get; set; }
    public bool IsActive { get; set; }
}