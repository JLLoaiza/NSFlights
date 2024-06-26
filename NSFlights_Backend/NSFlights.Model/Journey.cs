﻿
namespace Sales.Model
{
    public class Journey
    {
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public string FlightCarrier { get; set; }
        public string FlightNumber { get; set; }
        public double Price { get; set; }

        public Journey(string departureStation, string arrivalStation, string flightCarrier, string flightNumber, double price)
        {
            DepartureStation = departureStation;
            ArrivalStation = arrivalStation;
            FlightCarrier = flightCarrier;
            FlightNumber = flightNumber;
            Price = price;
        }
    }
}
