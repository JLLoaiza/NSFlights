using Sales.DAL.ApiService;
using Sales.DAL.Repositories.Interfaces;
using Sales.Model;

namespace Sales.DAL.Repositories
{
    public class JourneyRepository : IGenericRepository<JourneyResponse>
    {
        private readonly JourneyApi _ApiClient;

        public JourneyRepository(string url)
        {
            _ApiClient = new JourneyApi(url);
        }

        public async Task<JourneyResponse> GetAsync()
        {
            JourneyResponse responseData;

            try
            {
                responseData = await _ApiClient.GetAsync();

                return responseData;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error al obtener datos: {ex.Message}");
                throw;
            }
        }
    }
}
