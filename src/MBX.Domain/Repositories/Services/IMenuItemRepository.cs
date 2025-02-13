using MBX.Domain.Entities.Content;

namespace MBX.Domain.Repositories.Services;

public interface IMenuItemRepository : IGenericRepository<MenuItem>
{
    Task<IReadOnlyList<MenuItem>> GetMenuItemsByMenuAsync(Guid menuId);
    Task<IReadOnlyList<MenuItem>> GetMenuItemsByPageAsync(Guid pageId);
    Task<IReadOnlyList<MenuItem>> GetMenuItemsByParentAsync(Guid parentMenuItemId);
}