using MBX.Domain.Common;

namespace MBX.Domain.Entities.Payment
{
    public class PaymentInfo : BaseEntity
    {
        public decimal Amount { get; set; } // Số tiền thanh toán
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow; // Ngày thanh toán (mặc định UTC now)
        public string PaymentMethod { get; set; } = string.Empty; // Phương thức thanh toán - Non-nullable, default to empty string (Consider enum default if applicable)
        public string? TransactionId { get; set; } // Mã giao dịch (tùy chọn) - Nullable
        public string Status { get; set; } = string.Empty; // Trạng thái thanh toán - Non-nullable, default to empty string (Consider enum default if applicable)
        public string? PaymentGateway { get; set; } // Cổng thanh toán (PayPal, Stripe, etc.) (tùy chọn) - Nullable
        public string Currency { get; set; } = "VND"; // Đơn vị tiền tệ (mặc định USD) - Non-nullable, default to "USD"
        public string? Notes { get; set; } // Ghi chú thanh toán (tùy chọn) - Nullable
        public string? BankTransactionId { get; set; } // Mã giao dịch ngân hàng (tùy chọn) - Nullable
        public string? CheckNumber { get; set; } // Số séc (tùy chọn) - Nullable
        public string? CardNumber { get; set; } // Số thẻ (mã hóa) (tùy chọn) - Nullable
        public Guid OrderId { get; set; } // ID đơn hàng
        public Order.Order Order { get; set; } = null!; // Đơn hàng mà PaymentInfo thuộc về (Navigation)

    }
}