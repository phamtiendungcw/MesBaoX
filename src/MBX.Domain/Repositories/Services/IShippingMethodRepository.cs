using MBX.Domain.Entities.Orders;

namespace MBX.Domain.Repositories.Services;

public interface IShippingMethodRepository : IGenericRepository<ShippingMethod>
{
    Task<ShippingMethod?> GetShippingMethodByNameAsync(string methodName);
    Task<IReadOnlyList<ShippingMethod>> GetActiveShippingMethodsAsync();
    Task<IReadOnlyList<ShippingMethod>> GetShippingMethodsCheaperThanAsync(decimal maxCost);
}