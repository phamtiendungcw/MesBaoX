using MBX.Domain.Entities.Orders;

namespace MBX.Domain.Repositories.Services;

public interface IReturnStatusRepository : IGenericRepository<ReturnStatus>
{
    Task<ReturnStatus?> GetReturnStatusByNameAsync(string statusName);
    Task<IReadOnlyList<ReturnStatus>> GetActiveReturnStatusesAsync();
}