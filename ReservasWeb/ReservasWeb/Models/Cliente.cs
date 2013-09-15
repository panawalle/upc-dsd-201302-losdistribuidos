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

      [DisplayName("DNI")]
      public string dnicliente { get; set; }

      [DisplayName("Nombres")]
      public string nombrecliente { get; set; }

      [DisplayName("Apellidos")]
      public string apellidocliente { get; set; }

      [DisplayName("Correo")]
      public string correocliente { get; set; }

      [DisplayName("Sexo")]
      public string sexocliente { get; set; }

      [DisplayName("Fecha de Nacimiento")]
      public string fecnacliente { get; set; }

      [DisplayName("Distrito")]
      //public string distritocliente { get; set; }
      public Distrito distritocliente { get; set; }

      [DisplayName("Provincia")]
     //public string provinciacliente { get; set; }
      public Provincia provinciacliente { get; set; }

      [DisplayName("Departamento")]
      //public string departamentocliente { get; set; }
      public Departamento departamentocliente { get; set; }

      //[DisplayName("Contraseña")]
      //public string contrasena { get; set; }
    }
}
