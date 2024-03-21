
namespace Sales.Model
{
    public class JourneyResponse 
    {
        public List<Journey> Journeys { get; set; }

        public JourneyResponse(List<Journey> journeys)
        {
            Journeys = journeys;
        }
    }
}
