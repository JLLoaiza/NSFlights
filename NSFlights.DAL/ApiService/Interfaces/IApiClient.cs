namespace Sales.DAL.ApiService.Interfaces
{
    public interface IApiClient<T> where T : class
    {
        public Task<T> GetAsync();
        public Task<T> PostAsync(T data);
        public Task<T> PutAsync(T data);
        public Task<T> DeleteAsync(T data);
    }
}
