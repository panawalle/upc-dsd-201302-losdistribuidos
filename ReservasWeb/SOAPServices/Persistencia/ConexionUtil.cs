using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservasWeb.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=10.10.113.28;Initial Catalog=AUTODROMO;Integrated Security= True;";
        }
    }
}