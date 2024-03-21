
using Sales.Model;

namespace Sales.DTO
{
    public class JourneyDTO
    {
        public List<Flight> Flights { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }

        public JourneyDTO(List<Flight> flights, string origin, string destination, double price)
        {
            Flights = flights;
            Origin = origin;
            Destination = destination;
            Price = price;
        }

        public JourneyDTO(string origin, string destination)
        {
            Flights = [];
            Origin = origin;
            Destination = destination;
        }

        public JourneyDTO()
        {
            Flights = [];
            Origin = "";
            Destination = "";
        }

        public void SumPrice(double price)
        {
            Price += price;
        }

        public void AddFlight(Flight flight)
        {
            Flights.Add(flight);

            SumPrice(flight.Price);
        }

        public static implicit operator string(JourneyDTO v)
        {
            throw new NotImplementedException();
        }
    }
}
