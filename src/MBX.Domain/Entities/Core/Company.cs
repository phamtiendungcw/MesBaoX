using MBX.Domain.Common;

namespace MBX.Domain.Entities.Core
{
    public class Company : BaseEntity
    {
        public string Name { get; set; } = string.Empty; // Tên công ty - Non-nullable, default to empty string
        public string LegalName { get; set; } = string.Empty; // Tên pháp lý công ty - Non-nullable, default to empty string
        public string TaxCode { get; set; } = string.Empty; // Mã số thuế công ty - Non-nullable, default to empty string
        public string Address { get; set; } = string.Empty; // Địa chỉ công ty - Non-nullable, default to empty string
        public string PhoneNumber { get; set; } = string.Empty; // Số điện thoại công ty - Non-nullable, default to empty string
        public string Email { get; set; } = string.Empty; // Email công ty - Non-nullable, default to empty string
        public string? Website { get; set; } // Website công ty (tùy chọn) - Nullable
        public string? LogoUrl { get; set; } // URL logo công ty (tùy chọn) - Nullable
        public string CurrencyCode { get; set; } = string.Empty; // Mã đơn vị tiền tệ mặc định - Non-nullable, default to empty string
        public string TimeZoneId { get; set; } = string.Empty; // ID múi giờ công ty - Non-nullable, default to empty string
        public string Industry { get; set; } = string.Empty; // Ngành nghề kinh doanh - Non-nullable, default to empty string
        public string CompanySize { get; set; } = string.Empty; // Quy mô công ty - Non-nullable, default to empty string (Consider enum default if applicable)
        public DateTime RegistrationDate { get; set; } // Ngày đăng ký kinh doanh
        public string DefaultLanguage { get; set; } = string.Empty; // Ngôn ngữ mặc định - Non-nullable, default to empty string
        public int FiscalYearStartMonth { get; set; } // Tháng bắt đầu năm tài chính
        public string PaymentTerms { get; set; } = string.Empty; // Điều khoản thanh toán mặc định - Non-nullable, default to empty string
        public string ShippingTerms { get; set; } = string.Empty; // Điều khoản vận chuyển mặc định - Non-nullable, default to empty string
        public string? Theme { get; set; } // Giao diện tùy chỉnh (tùy chọn) - Nullable
        public string? CustomFields { get; set; } // Trường tùy chỉnh (JSON) - Nullable

    }
}