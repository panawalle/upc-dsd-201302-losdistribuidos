using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservasWeb.Models
{
    public class Horario
    {
        public string horario { get; set; }
        public string dia1 { get; set; }
        public string dia2 { get; set; }
        public string dia3 { get; set; }
        public string dia4 { get; set; }
        public string dia5 { get; set; }
        public string dia6 { get; set; }
        public List<HorarioBody> horarioBody { get; set; }
        public Boolean blnResultado { get; set; }

        public string strMensaje { get; set; }
    }
}