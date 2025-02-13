using MBX.Domain.Entities.Marketing;

namespace MBX.Domain.Repositories.Services;

public interface ISubscriberRepository : IGenericRepository<Subscriber>
{
    Task<Subscriber?> GetSubscriberByEmailAsync(string email);
    Task<IReadOnlyList<Subscriber>> GetActiveSubscribersAsync();
    Task<IReadOnlyList<Subscriber>> GetSubscribersJoinedAfterDateAsync(DateTime date);
}