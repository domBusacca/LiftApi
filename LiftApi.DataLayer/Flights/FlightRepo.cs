using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.Objects;

namespace LiftApi.DataLayer.Flights
{
    public class FlightRepo : IFlightRepo
    {
        private List<Flight> MockedFlightData;

        public FlightRepo()
        {
            MockedFlightData = GetMockedFlightData();
        }

        public List<Flight> GetFlights()
        {
            return MockedFlightData;
        }

        public Flight GetFlightById(int id)
        {
            var tempFlight = MockedFlightData.Find(x => x.FlightId == id);
            return tempFlight;
        }

        private List<Flight> GetMockedFlightData()
        {
            var FlightList = new List<Flight>();

            FlightList.Add(new Flight()
            {
                FlightId = 1,
                FlightInfo = new FlightInfo()
                {
                    FlightName = "FlightA",
                    MeetId = 1
                },
                LifterList = GetMockedLifterData()
            });

            FlightList.Add(new Flight()
            {
                FlightId = 1,
                FlightInfo = new FlightInfo()
                {
                    FlightName = "FlightB",
                    MeetId = 1
                },
                LifterList = GetMockedLifterData()
            });

            return FlightList;
        }

        private List<Lifter> GetMockedLifterData()
        {
            var tempList = new List<Lifter>();

            tempList.Add(new Lifter()
            {
                DivisionCd = "Gay Ass Raw",
                LifterId = 2,
                FirstName = "Drew",
                LastName = "Young"
            });

            tempList.Add(new Lifter()
            {
                DivisionCd = "Big Dick Equipped",
                LifterId = 1,
                FirstName = "Dom",
                LastName = "Busacca"
            });

            return tempList;
        }
    }
}
