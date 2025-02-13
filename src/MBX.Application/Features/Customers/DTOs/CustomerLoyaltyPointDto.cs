using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Customers.DTOs;

public class CustomerLoyaltyPointDto
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    [Required(ErrorMessage = "Points Earned are required")]
    [Range(0, int.MaxValue)]
    public int PointsEarned { get; set; }
    [Required(ErrorMessage = "Points Redeemed are required")]
    [Range(0, int.MaxValue)]
    public int PointsRedeemed { get; set; }
    public DateTime TransactionDate { get; set; }
    [MaxLength(1000)]
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}