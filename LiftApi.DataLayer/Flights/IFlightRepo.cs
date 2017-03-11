using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.Objects;

namespace LiftApi.DataLayer.Flights
{
    public interface IFlightRepo
    {
        List<Flight> GetFlights();

        Flight GetFlightById(int id);
    }
}
