using MBX.Domain.Common;

namespace MBX.Domain.Entities.Sales;

public class SalesOpportunity : BaseEntity
{
    public Guid CompanyId { get; set; } // ID công ty
    public Core.Company Company { get; set; } = null!; // Công ty mà cơ hội bán hàng thuộc về (Navigation)
    public string OpportunityName { get; set; } = string.Empty; // Tên cơ hội bán hàng
    public Guid CustomerId { get; set; } // ID khách hàng
    public Customer Customer { get; set; } = null!; // Khách hàng liên quan đến cơ hội (Navigation)
    public DateTime? ExpectedCloseDate { get; set; } // Ngày dự kiến chốt cơ hội (tùy chọn)
    public string Stage { get; set; } = string.Empty; // Giai đoạn cơ hội (enum: Qualification, NeedsAnalysis, etc.)
    public decimal? Probability { get; set; } // Xác suất thành công (tùy chọn)
    public decimal? EstimatedValue { get; set; } // Giá trị ước tính cơ hội (tùy chọn)
    public Guid SalespersonId { get; set; } // ID nhân viên bán hàng
    public Core.User Salesperson { get; set; } = null!; // Nhân viên bán hàng phụ trách (Navigation)
    public string? Notes { get; set; } // Ghi chú cơ hội (tùy chọn)
    public string? OpportunityCode { get; set; } // Mã cơ hội (tùy chọn)
    public string? OpportunityType { get; set; } // Loại cơ hội (tùy chọn)
    public string? Priority { get; set; } // Độ ưu tiên (enum: High, Medium, Low) (tùy chọn)
    public string? Competitors { get; set; } // Đối thủ cạnh tranh (tùy chọn)
    public string? SolutionProposed { get; set; } // Giải pháp đề xuất (tùy chọn)
    public string? NextStep { get; set; } // Bước tiếp theo (tùy chọn)
    public DateTime? LastStageChangeDate { get; set; } // Ngày thay đổi giai đoạn gần nhất (tùy chọn)
    public string? LostReason { get; set; } // Lý do mất cơ hội (tùy chọn)
    public decimal? EstimatedRevenue { get; set; } // Doanh thu ước tính (tùy chọn)
    public decimal WeightedRevenue => (decimal)(EstimatedValue * (Probability ?? 0))!; // Doanh thu có trọng số (tính toán)
    public string? ProductInterest { get; set; } // Sản phẩm/dịch vụ quan tâm (tùy chọn)
    public string? CustomFields { get; set; } // Trường tùy chỉnh (JSON)
}