using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Customers.DTOs;

public class CustomerGroupDto
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Group Name is required")]
    [MaxLength(255)]
    public string GroupName { get; set; } = string.Empty;
    [MaxLength(1000)]
    public string? Description { get; set; }
    [Range(0, 100)]
    public decimal? DiscountPercentage { get; set; }
    public bool IsActive { get; set; }
}