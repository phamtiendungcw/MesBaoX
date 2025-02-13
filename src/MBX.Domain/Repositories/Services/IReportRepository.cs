using MBX.Domain.Entities.Reporting;

namespace MBX.Domain.Repositories.Services;

public interface IReportRepository : IGenericRepository<Report>
{
    Task<Report?> GetReportNameAsync(string reportName);
    Task<IReadOnlyList<Report>> GetReportsByTypeAsync(string reportType);
    Task<IReadOnlyList<Report>> GetReportsCreatedByUserAsync(Guid userId);
}