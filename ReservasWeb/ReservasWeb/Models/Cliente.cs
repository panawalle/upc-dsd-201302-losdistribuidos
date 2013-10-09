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
      [DisplayName("Código")]
      public int codigocliente { get; set; }

      [DisplayName("DNI")]
      public string dnicliente { get; set; }

      [DisplayName("Tipo")]
      public int tipo { get; set; }

      [DisplayName("Nombres")]
      public string nombrecliente { get; set; }

      [DisplayName("Apellido Paterno")]
      public string apellidopaterno { get; set; }

      [DisplayName("Apellido Materno")]
      public string apellidomaterno { get; set; }

      [DisplayName("Dirección")]
      public string direccioncliente { get; set; }

      [DisplayName("Teléfono")]
      public string telefono { get; set; }

      [DisplayName("Celular")]
      public string celular { get; set; }

      [DisplayName("Correo")]
      public string correo { get; set; }
    }
}
