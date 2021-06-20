using Seguritas.Negocio;
using Seguritas.Negocio.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace Seguritas.API.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
        [Route("Home/GetClientes")]
        public ProcessResult GetClientes()
        {
            return FxClientes.ObtenerClientes();
        }

        //[HttpDelete]
        //[Route("Home/Delete")]
        //public async Task<ProcessResult> DeleteRecord()
        //{
        //    return await FxClientes.ObtenerClientes();
        //}
    }
}
