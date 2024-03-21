
namespace Sales.DAL.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<T> GetAsync();
    }
}
