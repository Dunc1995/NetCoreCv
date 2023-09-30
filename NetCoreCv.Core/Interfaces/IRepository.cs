namespace NetCoreCv.Core.Interfaces;
public interface IRepository<T>
{
    public Task<IEnumerable<T>> GetAllAsync();
}
