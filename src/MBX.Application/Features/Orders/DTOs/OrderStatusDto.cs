using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Orders.DTOs;

public class OrderStatusDto
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Status Name is required")]
    [MaxLength(255)]
    public string StatusName { get; set; } = string.Empty;
    [MaxLength(1000)]
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}