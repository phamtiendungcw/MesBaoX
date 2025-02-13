using MBX.Domain.Entities.Orders;

namespace MBX.Domain.Repositories.Services;

public interface IPaymentTransactionRepository : IGenericRepository<PaymentTransaction>
{
    Task<IReadOnlyList<PaymentTransaction>> GetPaymentTransactionsByOrderAsync(Guid orderId);
    Task<IReadOnlyList<PaymentTransaction>> GetPaymentTransactionsByStatusAsync(string transactionStatus);
    Task<IReadOnlyList<PaymentTransaction>> GetPaymentTransactionsAfterDateAsync(DateTime date);
}