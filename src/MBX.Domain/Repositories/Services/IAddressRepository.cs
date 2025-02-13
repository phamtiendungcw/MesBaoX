using MBX.Domain.Entities.Customers;

namespace MBX.Domain.Repositories.Services;

public interface IAddressRepository : IGenericRepository<Address>
{
    Task<IReadOnlyList<Address>> GetAddressesByCustomerIdAsync(Guid customerId);
    Task<Address?> GetDefaultShippingAddressAsync(Guid customerId);
}