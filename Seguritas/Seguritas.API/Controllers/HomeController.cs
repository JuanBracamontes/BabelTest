using Seguritas.Contexto.Utilities;
using Seguritas.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using Seguritas.API.Models;

namespace Seguritas.API.Controllers
{
    public class HomeController : Controller
    {
        // GET api/values
        [HttpGet]
        [Route("Home/GetHome")]
        public JsonResult GetHome()
        {
            var data = FxHome.ListarRegistros();
            return Json(data);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
