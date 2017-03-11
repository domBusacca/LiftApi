using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Net;
using LiftApi.Objects;
using LiftApi.BusinessLayer.Flights;
using LiftApi.DataLayer.Flights;
using System.Web.Http.Cors;

namespace LiftApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Flights")]
    public class FlightsController : ApiController
    {
        private readonly IFlightManager _flightManager;
        private readonly IFlightRepo _flightRepo;

        public FlightsController(IFlightManager flightManager, IFlightRepo flightRepo)
        {
            _flightManager = flightManager;
            _flightRepo = flightRepo;
        }

        [HttpGet]
        [Route("{flightId}")]
        public HttpResponseMessage GetFlight(int flightId)
        {
            try
            {
                var flight = _flightManager.GetFlight(flightId);

                if (flight == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Flight Id not Found");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, flight);
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("GetAllFlights")]
        public HttpResponseMessage GetFlights()
        {
            var FlightList = new List<Flight>();

            try
            {
                FlightList = _flightManager.GetFlights();
                return Request.CreateResponse(HttpStatusCode.OK, FlightList);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}