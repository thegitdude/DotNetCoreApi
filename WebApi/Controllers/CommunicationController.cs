using System;
using System.Web.Http;

namespace WebApi.Controllers
{
    [RoutePrefix("api/communication")]
    public class CommunicationController : ApiController
    {
        public CommunicationController()
        {
        }

        [HttpGet]
        [Route("getData")]
        public string GetData(){
            return "hello world";
        }
    }
}
