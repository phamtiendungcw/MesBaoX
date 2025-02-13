using System.ComponentModel.DataAnnotations;

namespace MBX.Application.Features.Customers.DTOs;

public class CustomerNoteDto
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Customer ID is required")]
    public Guid CustomerId { get; set; }
    [Required(ErrorMessage = "User ID is required")]
    public Guid UserId { get; set; }
    [Required(ErrorMessage = "Note Content is required")]
    [MaxLength(4000)]
    public string NoteContent { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}