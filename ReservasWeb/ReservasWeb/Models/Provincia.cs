using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace ReservasWeb.Models
{
    public class Provincia : Controller
    {
      [DisplayName("Código de Provincia")]
      public int codigoprovincia { get; set; }

      [DisplayName("Nombre de Provincia")]
      public string nombreprovincia { get; set; }
    }
}
