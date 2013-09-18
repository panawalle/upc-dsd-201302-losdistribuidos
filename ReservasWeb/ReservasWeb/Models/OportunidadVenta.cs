using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace ReservasWeb.Models
{
    public class OportunidadVenta : Controller
    {
        [DisplayName("CODIGO")]
        public string codServicio { get; set; }

        [DisplayName("Nombre")]
        public string nombreServicio { get; set; }

        [DisplayName("Cantidad")]
        public string cantidadServicio { get; set; }

        [DisplayName("Precio")]
        public string precioServicio { get; set; }

        
    }
}