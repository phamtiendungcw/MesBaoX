using MBX.Domain.Entities.Marketing;

namespace MBX.Domain.Repositories.Services;

public interface IEmailCampaignRepository : IGenericRepository<EmailCampaign>
{
    Task<EmailCampaign?> GetEmailCampaignByNameAsync(string campaignName);
    Task<IReadOnlyList<EmailCampaign>> GetEmailCampaignsByStatusAsync(string status);
    Task<IReadOnlyList<EmailCampaign>> GetEmailCampaignsSentAfterDateAsync(DateTime date);
}