using Newtonsoft.Json;
using Sales.DAL.ApiService.Interfaces;
using Sales.Model;

namespace Sales.DAL.ApiService
{
    public class JourneyApi : IApiClient<JourneyResponse>
    {
        private readonly HttpClient _httpClient;
        private readonly string _url;

        public JourneyApi(string url)
        {
            _httpClient = new HttpClient();
            _url = url;
        }

        public async Task<JourneyResponse> GetAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_url);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            Journey[] arr = JsonConvert.DeserializeObject<Journey[]>(json)!;

            return new JourneyResponse([.. arr]);
        }

        public Task<JourneyResponse> PostAsync(JourneyResponse data)
        {
            throw new NotImplementedException();
        }

        public Task<JourneyResponse> PutAsync(JourneyResponse data)
        {
            throw new NotImplementedException();
        }

        public Task<JourneyResponse> DeleteAsync(JourneyResponse data)
        {
            throw new NotImplementedException();
        }
    }
}
