namespace api.Interfaces
{
    public interface ICrudRepository
    {
        Task<List<T>> GetAllAsync<T>();
        Task<T?> GetByIdAsync<T>(int id);
        Task<T> CreateAsync<T>(T model);
        Task<T?> UpdateAsync<T>(int id, T model);
        Task<T?> DeleteAsync<T>(int id);
    }
}