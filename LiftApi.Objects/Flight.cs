using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftApi.Objects
{
    public class Flight
    {
        public int FlightId { get; set; }
        public FlightInfo FlightInfo { get; set; }
        public List<Lifter> LifterList { get; set;}
    }
}
