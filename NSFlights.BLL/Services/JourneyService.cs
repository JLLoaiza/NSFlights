
using Microsoft.Extensions.Caching.Memory;
using Sales.BLL.Services.Interfaces;
using Sales.DAL.Repositories;
using Sales.DTO;
using Sales.Model;

namespace Sales.BLL.Services
{
    public class JourneyService : IJourneyService
    {
        private readonly JourneyRepository _journeyRepository;
        private readonly IMemoryCache _cache;

        public JourneyService(string url)
        {
            _journeyRepository = new JourneyRepository(url);
            _cache = new MemoryCache(new MemoryCacheOptions());
        }

        public async Task<JourneyDTO> GetJourneyPath(string origin, string dest, int? maxFlights)
        {
            var cacheKey = (origin + ',' + dest);

            if (_cache.TryGetValue(cacheKey, out JourneyDTO? cachedJourneyPath))
            {
                return cachedJourneyPath!;
            }
            else
            {
                var journeys = await GetJourney();

                List<Flight> path = new List<Flight>();

                GetPathFromJourneys(journeys.Journeys, origin, dest, [], maxFlights, ref path);

                var JorneyPath = new JourneyDTO(path, origin, dest, path.Aggregate(0.0, (acc, x) => acc + x.Price));

                SaveJourney(cacheKey, JorneyPath);

                return JorneyPath;
            }
        }

        private async Task<JourneyResponse> GetJourney()
        {
            var journeys = await _journeyRepository.GetAsync();
            return journeys;
        }

        private void SaveJourney(string key, JourneyDTO responseData, int hours = 24)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromHours((hours)));

            _cache.Set(key, responseData, cacheEntryOptions);
        }

        private void GetPathFromJourneys(List<Journey> journeys, string origin, string dest, List<Flight> flights, int? maxFlights, ref List<Flight> result)
        {
            if (origin == dest)
            {
                if (maxFlights == null || flights.Count <= maxFlights)
                {
                    if (result.Count == 0)
                    {
                        result = new List<Flight>(flights);
                    }
                }
                return;
            }

            foreach (var journey in journeys)
            {
                var flight = new Flight(
                    journey.DepartureStation,
                    journey.ArrivalStation,
                    journey.Price,
                    new Transport(journey.FlightCarrier, journey.FlightNumber)
                    );

                if (flight.Origin == origin && !flights.Contains(flight))
                {
                    flights.Add(flight);
                    GetPathFromJourneys(journeys, flight.Destination, dest, flights, maxFlights, ref result);
                    flights.Remove(flight);
                }
            }
        }
    }
}
