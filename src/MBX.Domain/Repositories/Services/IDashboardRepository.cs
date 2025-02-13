using MBX.Domain.Entities.Reporting;

namespace MBX.Domain.Repositories.Services;

public interface IDashboardRepository : IGenericRepository<Dashboard>
{
    Task<Dashboard?> GetDashboardByNameAsync(string dashboardName);
    Task<IReadOnlyList<Dashboard>> GetDashboardsForUserAsync(Guid userId);
}