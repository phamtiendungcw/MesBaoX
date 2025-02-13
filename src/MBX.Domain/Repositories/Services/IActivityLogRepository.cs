using MBX.Domain.Entities.Logging;

namespace MBX.Domain.Repositories.Services;

public interface IActivityLogRepository : IGenericRepository<ActivityLog>
{
    Task<IReadOnlyList<ActivityLog>> GetActivityLogsByUserAsync(Guid userId);
    Task<IReadOnlyList<ActivityLog>> GetActivityLogsByTypeAsync(string activityType);
}