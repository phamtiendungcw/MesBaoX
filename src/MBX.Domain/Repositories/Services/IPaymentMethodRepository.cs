using MBX.Domain.Entities.Orders;

namespace MBX.Domain.Repositories.Services;

public interface IPaymentMethodRepository : IGenericRepository<PaymentMethod>
{
    Task<PaymentMethod?> GetPaymentMethodByNameAsync(string methodName);
    Task<IReadOnlyList<PaymentMethod>> GetActivePaymentMethodsAsync();
}