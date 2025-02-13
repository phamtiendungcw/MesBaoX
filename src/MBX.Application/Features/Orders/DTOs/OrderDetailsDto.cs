using MBX.Application.Features.Customers.DTOs;
using MBX.Application.Features.Promotions.DTOs;

namespace MBX.Application.Features.Orders.DTOs;

public class OrderDetailsDto : OrderDto
{
    public OrderStatusDto? OrderStatus { get; set; }
    public AddressDto? ShippingAddress { get; set; }
    public AddressDto? BillingAddress { get; set; }
    public PaymentMethodDto? PaymentMethod { get; set; }
    public ShippingMethodDto? ShippingMethod { get; set; }
    public List<OrderItemDto>? OrderItems { get; set; }
    public List<PaymentTransactionDto>? PaymentTransactions { get; set; }
    public List<OrderCouponDto>? OrderCoupons { get; set; }
    public List<OrderReturnDto>? OrderReturns { get; set; }
    public List<ShipmentDto>? Shipments { get; set; }
}