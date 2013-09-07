using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservaCitasWeb.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "RESERVA DE CITAS";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
