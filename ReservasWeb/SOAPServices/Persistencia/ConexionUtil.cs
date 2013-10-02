using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace ReservasWeb.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=localhost;Initial Catalog=AUTODROMO;Integrated Security= True;";
        }

        private SqlConnection cnx;

        public SqlConnection fnObtenerConexion()
        {

            cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

            return cnx;

        }
    }
}