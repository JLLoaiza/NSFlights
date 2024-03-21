using Sales.DTO;
using Sales.Model;

namespace Sales.BLL.Services.Interfaces
{
    public interface IJourneyService
    {
        public Task<JourneyDTO> GetJourneyPath(string origin, string dest, int? maxFlights);
    }
}
