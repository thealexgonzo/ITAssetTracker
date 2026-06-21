namespace ITAssetTracker.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T : class
    {
        // NOTE: Generic Requests and Commands
        Task<T?> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
