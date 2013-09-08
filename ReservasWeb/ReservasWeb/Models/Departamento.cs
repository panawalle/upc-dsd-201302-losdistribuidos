using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace ReservasWeb.Models
{
    public class Departamento : Controller
    {
      [DisplayName("Código de Departamento")]
      public int codigodepartamento { get; set; }

      [DisplayName("Nombre de Departamento")]
      public string nombredepartamento { get; set; }

    }
}
