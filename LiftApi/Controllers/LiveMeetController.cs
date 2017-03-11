using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using LiftApi.BusinessLayer.LiveMeets;
using LiftApi.DataLayer.Flights;
using LiftApi.DataLayer.Lifters;
using LiftApi.DataLayer.Meets;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Net.Http;

namespace LiftApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/LiveMeet")]
    public class LiveMeetController : ApiController
    {
        private readonly IMeetRepo _meetRepo;
        private readonly ILifterRepo _lifterRepo;
        private readonly IFlightRepo _flightRepo;
        private readonly ILiveMeetBuilder _liveMeetBuilder;

        public LiveMeetController(IMeetRepo meetRepo, ILifterRepo lifterRepo, IFlightRepo flightRepo, ILiveMeetBuilder liveMeetBuilder)
        {
            _meetRepo = meetRepo;
            _lifterRepo = lifterRepo;
            _flightRepo = flightRepo;
            _liveMeetBuilder = liveMeetBuilder;
        }

        [HttpGet]
        [Route("{meetId}")]
        public HttpResponseMessage GetLiveMeet(int meetId)
        {
            try
            {
                var meet = _liveMeetBuilder.BuildLiveMeet(meetId);

                if (meet == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Meet Id not Found");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, meet);
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
