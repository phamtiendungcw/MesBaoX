using MBX.Domain.Common;

namespace MBX.Domain.Entities.Sales
{
    public class Customer : BaseEntity
    {
        public Guid CompanyId { get; set; } // ID công ty
        public Core.Company Company { get; set; } = null!; // Công ty mà khách hàng thuộc về (Navigation)
        public string? CustomerCode { get; set; } // Mã khách hàng (tùy chọn)
        public string CustomerType { get; set; } = string.Empty; // Loại khách hàng (enum: Individual, Company)
        public string? FirstName { get; set; } // Tên khách hàng cá nhân (tùy chọn)
        public string? LastName { get; set; } // Họ khách hàng cá nhân (tùy chọn)
        public string? FullName => $"{FirstName} {LastName}"; // Tên đầy đủ (tính toán)
        public string? CompanyName { get; set; } // Tên công ty (tùy chọn)
        public string? TaxCode { get; set; } // Mã số thuế công ty (tùy chọn)
        public string? ContactName { get; set; } // Tên người liên hệ chính (tùy chọn)
        public string Address { get; set; } = string.Empty; // Địa chỉ khách hàng
        public string PhoneNumber { get; set; } = string.Empty; // Số điện thoại khách hàng
        public string Email { get; set; } = string.Empty; // Email khách hàng
        public string? Website { get; set; } // Website khách hàng (tùy chọn)
        public Guid? CustomerGroupId { get; set; } // ID nhóm khách hàng (tùy chọn)
        public CustomerGroup? CustomerGroup { get; set; } // Nhóm khách hàng (Navigation)
        public Guid? SalespersonId { get; set; } // ID nhân viên bán hàng (tùy chọn)
        public Core.User? Salesperson { get; set; } // Nhân viên bán hàng (Navigation)
        public string? Source { get; set; } // Nguồn gốc khách hàng (tùy chọn)
        public string? Notes { get; set; } // Ghi chú khách hàng (tùy chọn)
        public string CustomerStatus { get; set; } = string.Empty; // Trạng thái khách hàng (enum: Lead, Prospect, Active, Inactive, OnHold)
        public string? Industry { get; set; } // Ngành nghề khách hàng (tùy chọn)
        public decimal? AnnualRevenue { get; set; } // Doanh thu hàng năm (tùy chọn)
        public int? NumberOfEmployees { get; set; } // Số lượng nhân viên (tùy chọn)
        public string? PaymentTerms { get; set; } // Điều khoản thanh toán (tùy chọn)
        public string? ShippingTerms { get; set; } // Điều khoản vận chuyển (tùy chọn)
        public string? BillingContactName { get; set; } // Tên người liên hệ thanh toán (tùy chọn)
        public string? BillingContactEmail { get; set; } // Email người liên hệ thanh toán (tùy chọn)
        public string? BillingContactPhone { get; set; } // Số điện thoại người liên hệ thanh toán (tùy chọn)
        public string? ShippingContactName { get; set; } // Tên người liên hệ giao hàng (tùy chọn)
        public string? ShippingContactEmail { get; set; } // Email người liên hệ giao hàng (tùy chọn)
        public string? ShippingContactPhone { get; set; } // Số điện thoại người liên hệ giao hàng (tùy chọn)
        public string? Rating { get; set; } // Đánh giá khách hàng (enum: Hot, Warm, Cold) (tùy chọn)
        public string? SocialMediaLinks { get; set; } // Liên kết mạng xã hội (JSON) (tùy chọn)
        public string? CustomFields { get; set; } // Trường tùy chỉnh (JSON)
    }
}