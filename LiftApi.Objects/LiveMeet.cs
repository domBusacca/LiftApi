using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftApi.Objects
{
    public class LiveMeet
    {
        public MeetInfo Meet { get; set; }
        public List<Flight> FlightList { get; set; }
    }
}
