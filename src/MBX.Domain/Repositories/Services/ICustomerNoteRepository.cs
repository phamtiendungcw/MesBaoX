using MBX.Domain.Entities.Customers;

namespace MBX.Domain.Repositories.Services;

public interface ICustomerNoteRepository : IGenericRepository<CustomerNote>
{
    Task<IReadOnlyList<CustomerNote>> GetCustomerNotesByCustomerAsync(Guid customerId);
    Task<IReadOnlyList<CustomerNote>> GetCustomerNotesByUserAsync(Guid userId);
}