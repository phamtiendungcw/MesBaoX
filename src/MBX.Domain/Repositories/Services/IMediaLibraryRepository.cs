using MBX.Domain.Entities.Content;

namespace MBX.Domain.Repositories.Services;

public interface IMediaLibraryRepository : IGenericRepository<MediaLibrary>
{
    Task<IReadOnlyList<MediaLibrary>> GetMediaByMediaTypeAsync(string mediaType);
    Task<IReadOnlyList<MediaLibrary>> GetMediaUploadedByUserAsync(Guid userId);
    Task<IReadOnlyList<MediaLibrary>> SearchMediaByFilenameAsync(string filenameKeyword);
}