using MBX.Domain.Entities.Content;

namespace MBX.Domain.Repositories.Services;

public interface IPageRepository : IGenericRepository<Page>
{
    Task<Page?> GetPageBySlugAsync(string slug);
    Task<IReadOnlyList<Page>> GetActivePagesAsync();
    Task<IReadOnlyList<Page>> GetPagesWithContentBlocksAsync();
}