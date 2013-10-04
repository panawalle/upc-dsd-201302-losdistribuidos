using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace RESTServices.Persistencia
{
    public class ConexionUtil
    {
        public static string Cadena()
        {
            return "Data Source=(local);Initial Catalog=AUTOMOTRIZ;Integrated Security=SSPI;";
        }

        private SqlConnection cnx;

        public SqlConnection fnObtenerConexion()
        {

            cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

            return cnx;

        }

    }
}