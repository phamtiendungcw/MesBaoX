namespace MBX.Application.Features.Marketing.DTOs
{
    public class EmailCampaignDto
    {
        public Guid Id { get; set; }
        public string CampaignName { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string? Segment { get; set; }
        public string? Status { get; set; }
        public bool IsActive { get; set; }
    }
}
