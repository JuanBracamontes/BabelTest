using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Seguritas.Portal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("https://localhost:4421/Home");
                var responseTask = cliente.GetAsync("GetHomeData");
                responseTask.Wait();
                
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}