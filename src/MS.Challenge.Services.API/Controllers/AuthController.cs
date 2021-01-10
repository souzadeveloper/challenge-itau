using MS.Challenge.Domain.Interfaces.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MS.Challenge.Services.API.Controllers
{
    [RoutePrefix("api")]
    public class AuthController : BaseController
    {
        private readonly IAuthApplicationService _service;

        public AuthController(IAuthApplicationService service)
        {
            _service = service;
        }

        [Route("auth/checkPassword")]
        [HttpPost]
        public Task<HttpResponseMessage> CheckPassword([FromBody]dynamic body)
        {
            try
            {
                if (body.password == null)
                    return CreateErrorResponse(HttpStatusCode.BadRequest, "Error", "password is required.");

                var result = _service.CheckPassword(body.password.ToString());
                return CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return CreateErrorResponse(HttpStatusCode.InternalServerError, "Error", ex.Message);
            }
        }
    }
}