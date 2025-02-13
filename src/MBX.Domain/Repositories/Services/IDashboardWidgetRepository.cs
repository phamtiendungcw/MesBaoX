using MBX.Domain.Entities.Reporting;

namespace MBX.Domain.Repositories.Services;

public interface IDashboardWidgetRepository : IGenericRepository<DashboardWidget>
{
    Task<IReadOnlyList<DashboardWidget>> GetDashboardWidgetsByDashboardAsync(Guid dashboardId);
    Task<IReadOnlyList<DashboardWidget>> GetDashboardWidgetsByTypeAsync(string widgetType);
}