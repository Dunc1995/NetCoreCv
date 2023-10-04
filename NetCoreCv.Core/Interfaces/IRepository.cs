namespace NetCoreCv.Core.Interfaces;
public interface IRepository<T>
{
    public Task<IEnumerable<T>> GetAllAsync();

    public Task PutAsync(T model);

    public Task<T?> GetAsync(int id);

    public Task DeleteAsync(int id);
}
