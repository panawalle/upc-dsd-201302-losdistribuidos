using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class ConexionUtil
    {
        public static string Cadena()
        {
            return "Data Source=(local);Initial Catalog=AUTOMOTRIZ;Integrated Security=SSPI;";
        }
    }
}