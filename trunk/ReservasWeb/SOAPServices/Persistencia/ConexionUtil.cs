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
            return "Data Source=LESLY-VAIO\\SQLEXPRESS;Initial Catalog=AUTODROMO;Integrated Security= SSPI;";
        }
    }
}