using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservasWeb.Controllers
{
    public class VehiculoController : Controller
    {
        //
        // GET: /Vehiculo/

        public ActionResult Index()
        {
            ViewData["saludito"] = "Hola Luchito Cabañas";
            return View();
        }

    }
}
