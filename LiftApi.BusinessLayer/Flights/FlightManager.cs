using System;
using System.Collections.Generic;
using System.Linq;
using LiftApi.Objects;
using LiftApi.DataLayer.Flights;

namespace LiftApi.BusinessLayer.Flights
{
    public class FlightManager : IFlightManager
    {
        private readonly IFlightRepo _flightRepo;

        public FlightManager(IFlightRepo flightRepo)
        {
            _flightRepo = flightRepo;
        }

        public List<Flight> GetFlights()
        {
            return _flightRepo.GetFlights();
        }

        public Flight GetFlight(int id)
        {
            return _flightRepo.GetFlightById(id);
        }
    }
}
