using MBX.Domain.Entities.Configuration;

namespace MBX.Domain.Repositories.Services;

public interface ISettingRepository : IGenericRepository<Setting>
{
    Task<Setting?> GetSettingByKeyAsync(string settingKey);
    Task<IReadOnlyList<Setting>> GetSettingsByGroupAsync(string settingGroup);
}