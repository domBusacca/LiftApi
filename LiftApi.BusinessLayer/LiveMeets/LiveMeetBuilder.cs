using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftApi.DataLayer.Flights;
using LiftApi.DataLayer.Meets;
using LiftApi.DataLayer.Lifters;
using LiftApi.Objects;

namespace LiftApi.BusinessLayer.LiveMeets
{
    public class LiveMeetBuilder : ILiveMeetBuilder
    {
        private readonly IFlightRepo _flightRepo;
        private readonly IMeetRepo _meetRepo;
        private readonly ILifterRepo _lifterRepo;

        public LiveMeetBuilder(IFlightRepo flightRepo, IMeetRepo meetRepo, ILifterRepo lifterRepo)
        {
            _flightRepo = flightRepo;
            _meetRepo = meetRepo;
            _lifterRepo = lifterRepo;
        }

        public LiveMeet BuildLiveMeet(int meetId)
        {
            var liveMeet = new LiveMeet();
            var meet = BuildMeet(meetId);

            if (meet == null)
            {
                return null;
            }

            liveMeet.Meet = meet;
            liveMeet.FlightList = BuildFlights(meetId);

            return liveMeet;
        }

        private MeetInfo BuildMeet(int meetId)
        {
            return _meetRepo.GetMeetById(meetId);
        }

        private List<Flight> BuildFlights(int meetId)
        {
            var flightList = _flightRepo.GetFlights().FindAll(x => x.FlightInfo.MeetId == meetId);
            return flightList;
        }
    }
}
