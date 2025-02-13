using MBX.Domain.Entities.Content;

namespace MBX.Domain.Repositories.Services;

public interface IContentBlockRepository : IGenericRepository<ContentBlock>
{
    Task<ContentBlock?> GetContentBlockByNameAsync(string blockName);
    Task<IReadOnlyList<ContentBlock>> GetActiveContentBlocksAsync();
}