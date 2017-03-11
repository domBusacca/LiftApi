using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Net;
using LiftApi.Objects;
using System.Web.Http.Cors;
using LiftApi.BusinessLayer.Meets;
using LiftApi.DataLayer.Meets;

namespace LiftApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Meets")]
    public class MeetController : ApiController
    {
        private readonly IMeetManager _meetManager;
        private readonly IMeetRepo _meetRepo;

        public MeetController(IMeetManager meetManager, IMeetRepo meetRepo)
        {
            _meetManager = meetManager;
            _meetRepo = meetRepo;
        }

        [HttpGet]
        [Route("{meetId}")]
        public HttpResponseMessage GetMeet(int meetId)
        {
            try
            {
                var meet = _meetManager.GetMeet(meetId);

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

        [HttpGet]
        [Route("GetAllMeets")]
        public HttpResponseMessage GetMeets()
        {
            try
            {
                var meetList = _meetManager.GetAllMeets();
                return Request.CreateResponse(HttpStatusCode.OK, meetList);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}