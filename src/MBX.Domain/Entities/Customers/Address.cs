using MBX.Domain.Entities.Orders;

using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Customers;

public class Address : BaseEntity
{
    [Required] public Guid CustomerId { get; set; } // ID khách hàng (khóa ngoại đến bảng Customer, bắt buộc)
    public virtual Customer Customer { get; set; } = null!; // Navigation property cho khách hàng (bắt buộc)
    [Required][MaxLength(255)] public string AddressLine1 { get; set; } = string.Empty; // Địa chỉ dòng 1 (bắt buộc, độ dài tối đa 255 ký tự)
    [MaxLength(255)] public string? AddressLine2 { get; set; } // Địa chỉ dòng 2 (không bắt buộc, độ dài tối đa 255 ký tự)
    [Required][MaxLength(100)] public string City { get; set; } = string.Empty; // Thành phố (bắt buộc, độ dài tối đa 100 ký tự)
    [Required][MaxLength(100)] public string StateProvince { get; set; } = string.Empty; // Tỉnh/Thành phố trực thuộc TW (bắt buộc, độ dài tối đa 100 ký tự)
    [MaxLength(20)] public string? ZipCode { get; set; } // Mã bưu điện (không bắt buộc, độ dài tối đa 20 ký tự)
    [Required][MaxLength(100)] public string Country { get; set; } = string.Empty; // Quốc gia (bắt buộc, độ dài tối đa 100 ký tự)
    public bool IsDefaultShippingAddress { get; set; } // Xác định địa chỉ là địa chỉ giao hàng mặc định (mặc định false)
    public bool IsDefaultBillingAddress { get; set; } // Xác định địa chỉ là địa chỉ thanh toán mặc định (mặc định false)

    #region Navigation properties

    public virtual ICollection<Order> ShippingOrders { get; set; } = new List<Order>(); // Danh sách các đơn hàng sử dụng địa chỉ này làm địa chỉ giao hàng
    public virtual ICollection<Order> BillingOrders { get; set; } = new List<Order>(); // Danh sách các đơn hàng sử dụng địa chỉ này làm địa chỉ thanh toán

    #endregion
}