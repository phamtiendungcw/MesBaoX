using MBX.Domain.Entities.Customers;

namespace MBX.Domain.Repositories.Services;

public interface ICustomerLoyaltyPointRepository : IGenericRepository<CustomerLoyaltyPoint>
{
    Task<IReadOnlyList<CustomerLoyaltyPoint>> GetLoyaltyPointsByCustomerAsync(Guid customerId);
    Task<int> GetTotalPointsEarnedByCustomerAsync(Guid customerId);
}