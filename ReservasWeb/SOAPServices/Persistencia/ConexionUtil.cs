using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace SOAPServices.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=10.10.113.28;Initial Catalog=AUTODROMO;Integrated Security= True;";
        }

        private SqlConnection cnx;

        public SqlConnection fnObtenerConexion()
        {

            cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

            return cnx;

        }
    }
}