using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace ReservasWeb.Models
{
    public class Cliente : Controller
    {

      [DisplayName("CODIGO")]
      public int codigocliente { get; set; }

      [DisplayName("DNI")]
      public string dnicliente { get; set; }

      [DisplayName("TIPO")]
      public int tipo { get; set; }

      [DisplayName("NOMBRE")]
      public string nombrecliente { get; set; }

      [DisplayName("APELLIDO PATERNO")]
      public string apellidopaterno { get; set; }

      [DisplayName("APELLIDO MATERNO")]
      public string apellidomaterno { get; set; }

      [DisplayName("DIRECCION")]
      public string direccioncliente { get; set; }

      [DisplayName("TELEFONO")]
      public string telefono { get; set; }

      [DisplayName("CELULAR")]
      public string celular { get; set; }

      [DisplayName("CORREO")]
      public string correo { get; set; }
    }
}
