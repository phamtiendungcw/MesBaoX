using MBX.Domain.Entities.Customers;

namespace MBX.Domain.Repositories.Services;

public interface ICustomerGroupRepository : IGenericRepository<CustomerGroup>
{
    Task<CustomerGroup?> GetCustomerGroupByNameAsync(string groupName);
    Task<IReadOnlyList<CustomerGroup>> GetActiveCustomerGroupsAsync();
}