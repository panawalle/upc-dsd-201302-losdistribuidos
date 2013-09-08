using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservasWeb.Controllers {
  [HandleError]
  public class HomeController : Controller {
    public ActionResult Index() {
      ViewData["Message"] = "Bienvenidos, realice su reserva.";

      return View();
    }

    public ActionResult About() {
      return View();
    }
  }
}
