using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MS.Challenge.Services.API.Controllers
{
    public class BaseController : ApiController
    {
        public new HttpResponseMessage ResponseMessage;

        public BaseController()
        {
            ResponseMessage = new HttpResponseMessage();
        }

        public Task<HttpResponseMessage> CreateResponse(HttpStatusCode code, object result)
        {
            ResponseMessage = Request.CreateResponse(code, result);
            return Task.FromResult(ResponseMessage);
        }

        public Task<HttpResponseMessage> CreateErrorResponse(HttpStatusCode code, string title, string message)
        {
            ResponseMessage = Request.CreateResponse(code, new { title, message });
            return Task.FromResult(ResponseMessage);
        }
    }
}