using MBX.Application.Features.Orders.DTOs;
using MBX.Application.Features.Products.DTOs;

namespace MBX.Application.Features.Customers.DTOs;

public class CustomerDetailsDto : CustomerDto
{
    public DateTime? DateOfBirth { get; set; }
    public string? Gender { get; set; }
    public List<AddressDto>? Addresses { get; set; }
    public List<OrderDto>? Orders { get; set; }
    public List<CustomerLoyaltyPointDto>? LoyaltyPoints { get; set; }
    public List<CustomerNoteDto>? CustomerNotes { get; set; }
    public List<ProductReviewDto>? ProductReviews { get; set; }
    public List<CustomerGroupDto>? CustomerGroups { get; set; }
}