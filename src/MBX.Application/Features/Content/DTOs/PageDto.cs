namespace MBX.Application.Features.Content.DTOs
{
    public class PageDto
    {
        public Guid Id { get; set; }
        public string PageTitle { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
