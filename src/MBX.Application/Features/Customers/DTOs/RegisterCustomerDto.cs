using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Customers.DTOs;

public class RegisterCustomerDto
{
    [Required(ErrorMessage = "First Name is required")]
    [MaxLength(255)]
    public string FirstName { get; set; } = string.Empty;
    [Required(ErrorMessage = "Last Name is required")]
    [MaxLength(255)]
    public string LastName { get; set; } = string.Empty;
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [MaxLength(255)]
    public string Email { get; set; } = string.Empty;
    [MaxLength(20)]
    public string? PhoneNumber { get; set; }
    [Required(ErrorMessage = "Password is required")]
    [MinLength(8)]
    public string Password { get; set; } = string.Empty;
    [Required(ErrorMessage = "Confirm Password is required")]
    [Compare("Password")]
    public string ConfirmPassword { get; set; } = string.Empty;
    public DateTime? DateOfBirth { get; set; }
    [MaxLength(20)]
    public string? Gender { get; set; }
    public bool IsActive { get; set; }
}