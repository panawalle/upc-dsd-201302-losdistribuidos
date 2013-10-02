using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservasWeb.Models
{
    public class ReservaDetalle
    {
        public Servicio servicio { get; set; }
        public string estado { get; set; }
    }
}