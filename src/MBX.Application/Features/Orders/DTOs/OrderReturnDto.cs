using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Orders.DTOs;

public class OrderReturnDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public DateTime ReturnDate { get; set; }
    [Required(ErrorMessage = "Return Reason is required")]
    [MaxLength(4000)]
    public string ReturnReason { get; set; } = string.Empty;
    [Required(ErrorMessage = "Return Status ID is required")]
    public Guid ReturnStatusId { get; set; }
    [Range(0, double.MaxValue)]
    public decimal? RefundAmount { get; set; }
    [MaxLength(4000)]
    public string? ReturnNotes { get; set; }
    public bool IsActive { get; set; }
}