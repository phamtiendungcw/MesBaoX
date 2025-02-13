using MBX.Domain.Entities.Customers;

namespace MBX.Domain.Repositories.Services;

public interface ICustomerRepository : IGenericRepository<Customer>
{
    Task<Customer?> GetCustomerByEmailAsync(string email);
    Task<IReadOnlyList<Customer>> GetCustomersByGroupAsync(Guid customerGroupId);
    Task<IReadOnlyList<Customer>> GetCustomersBornBeforeDateAsync(DateTime date);
}