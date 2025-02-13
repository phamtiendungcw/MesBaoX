using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Orders.DTOs;

public class PaymentTransactionDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public DateTime TransactionDate { get; set; }
    [Required(ErrorMessage = "Transaction Amount is required")]
    [Range(0.01, double.MaxValue)]
    public decimal TransactionAmount { get; set; }
    [Required(ErrorMessage = "Transaction Status is required")]
    [MaxLength(255)]
    public string TransactionStatus { get; set; } = string.Empty;
    [MaxLength(255)]
    public string? PaymentGateway { get; set; }
    [MaxLength(255)]
    public string? TransactionId { get; set; }
    public bool IsActive { get; set; }
}