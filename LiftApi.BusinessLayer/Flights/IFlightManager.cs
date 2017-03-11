using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.Objects;

namespace LiftApi.BusinessLayer.Flights
{
    public interface IFlightManager
    {
        List<Flight> GetFlights();

        Flight GetFlight(int id);
    }
}
