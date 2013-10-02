using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservasWeb.Models
{
    public class Modelo
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public Marca marca { get; set; }
    }
}