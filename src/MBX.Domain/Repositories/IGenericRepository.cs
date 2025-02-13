using Abp.Specifications;

using MBX.Domain.Entities;

using System.Linq.Expressions;

namespace MBX.Domain.Repositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    /// <summary>
    ///     Lấy một entity theo ID bất đồng bộ.
    /// </summary>
    /// <param name="id">ID duy nhất của entity.</param>
    /// <returns>Task đại diện cho thao tác bất đồng bộ. Kết quả Task chứa entity nếu tìm thấy, ngược lại trả về null.</returns>
    Task<T?> GetByIdAsync(Guid id);

    /// <summary>
    ///     Lấy tất cả các entities thuộc kiểu T bất đồng bộ.
    /// </summary>
    /// <returns>Task đại diện cho thao tác bất đồng bộ. Kết quả Task chứa một danh sách chỉ đọc các entities.</returns>
    Task<IReadOnlyList<T>> ListAllAsync();

    /// <summary>
    ///     Tìm kiếm các entities thỏa mãn một predicate (biểu thức điều kiện) bất đồng bộ.
    /// </summary>
    /// <param name="predicate">Biểu thức lambda để lọc entities.</param>
    /// <returns>
    ///     Task đại diện cho thao tác bất đồng bộ. Kết quả Task chứa một danh sách chỉ đọc các entities thỏa mãn
    ///     predicate.
    /// </returns>
    Task<IReadOnlyList<T>> FindAsync(Expression<Func<T, bool>> predicate);

    /// <summary>
    ///     Lấy entity đầu tiên thỏa mãn một predicate bất đồng bộ, hoặc null nếu không tìm thấy.
    /// </summary>
    /// <param name="predicate">Biểu thức lambda để lọc entities.</param>
    /// <returns>Task đại diện cho thao tác bất đồng bộ. Kết quả Task chứa entity đầu tiên tìm thấy hoặc null.</returns>
    Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);

    /// <summary>
    ///     Kiểm tra xem có bất kỳ entity nào thỏa mãn một predicate bất đồng bộ hay không.
    /// </summary>
    /// <param name="predicate">Biểu thức lambda để lọc entities.</param>
    /// <returns>
    ///     Task đại diện cho thao tác bất đồng bộ. Kết quả Task là true nếu có entity thỏa mãn predicate, ngược lại là
    ///     false.
    /// </returns>
    Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);

    /// <summary>
    ///     Lấy danh sách chỉ đọc các entities thỏa mãn đặc điểm kỹ thuật được cung cấp bất đồng bộ.
    /// </summary>
    /// <param name="spec">Đặc điểm kỹ thuật đóng gói logic truy vấn.</param>
    /// <returns>
    ///     Task đại diện cho thao tác bất đồng bộ. Kết quả Task chứa danh sách chỉ đọc các entities thỏa mãn
    ///     đặc điểm kỹ thuật.
    /// </returns>
    Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);

    /// <summary>
    ///     Đếm số lượng entities thỏa mãn đặc điểm kỹ thuật được cung cấp bất đồng bộ.
    /// </summary>
    /// <param name="spec">Đặc điểm kỹ thuật đóng gói logic đếm.</param>
    /// <returns>Task đại diện cho thao tác bất đồng bộ. Kết quả Task chứa số lượng entities thỏa mãn đặc điểm kỹ thuật.</returns>
    Task<int> CountAsync(ISpecification<T> spec);

    /// <summary>
    ///     Thêm một entity mới vào repository bất đồng bộ.
    /// </summary>
    /// <param name="entity">Entity cần thêm.</param>
    /// <returns>Task đại diện cho thao tác bất đồng bộ. Kết quả Task chứa entity đã được thêm.</returns>
    Task<T> AddAsync(T entity);

    /// <summary>
    ///     Cập nhật một entity đã tồn tại trong repository bất đồng bộ.
    /// </summary>
    /// <param name="entity">Entity cần cập nhật.</param>
    /// <returns>Task đại diện cho thao tác bất đồng bộ.</returns>
    Task UpdateAsync(T entity);

    /// <summary>
    ///     Xóa một entity khỏi repository bất đồng bộ.
    /// </summary>
    /// <param name="entity">Entity cần xóa.</param>
    /// <returns>Task đại diện cho thao tác bất đồng bộ.</returns>
    Task DeleteAsync(T entity);
}