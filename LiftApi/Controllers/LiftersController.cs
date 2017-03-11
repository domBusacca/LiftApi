using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Net;
using LiftApi.Objects;
using System.Web.Http.Cors;
using LiftApi.BusinessLayer.Lifters;
using LiftApi.DataLayer.Lifters;


namespace LiftApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Lifters")]
    public class LiftersController : ApiController
    {
        private readonly ILifterManager _lifterManager;
        private readonly ILifterRepo _lifterRepo;

        public LiftersController(ILifterManager lifterManager, ILifterRepo lifterRepo)
        {
            _lifterManager = lifterManager;
            _lifterRepo = lifterRepo;
        }

        [HttpGet]
        [Route("{lifterId}")]
        public HttpResponseMessage GetLifter(int lifterId)
        {
            try
            {
                var meet = _lifterManager.GetLifter(lifterId);

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
        [Route("GetAllLifters")]
        public HttpResponseMessage GetLifters()
        {
            try
            {
                var meetList = _lifterManager.GetAllLifters();
                return Request.CreateResponse(HttpStatusCode.OK, meetList);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}