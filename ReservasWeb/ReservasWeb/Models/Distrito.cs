using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace ReservasWeb.Models
{
    public class Distrito : Controller
    {
      [DisplayName("Código de Distrito")]
      public int codigodistrito { get; set; }

      [DisplayName("Nombre de Distrito")]
      public string nombredistrito { get; set; }
    }
}
