namespace MBX.Application.Features.Configuration.DTOs;

public class SettingDto
{
    public Guid Id { get; set; }
    public string SettingKey { get; set; } = string.Empty;
    public string? SettingValue { get; set; }
    public string? SettingGroup { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}