using Seguritas.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Seguritas.API.Controllers
{
    public class ClientesController : ApiController
    {
        // GET api/values
        [HttpGet]
        [Route("Clientes/ObtenerListado")]
        public HttpResponseMessage Get()
        {
            var data = FxClientes.ObtenerClientes();
            if (data.Status != Negocio.Utilities.ProcessResult.StatusCode.Complete)
            {
                HttpError errorMessage = new HttpError(data.Mensaje);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, errorMessage);
            }
            else
                return Request.CreateResponse(HttpStatusCode.OK,data);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("Clientes/Borrar")]
        public void Delete(int id)
        {

        }
    }
}
