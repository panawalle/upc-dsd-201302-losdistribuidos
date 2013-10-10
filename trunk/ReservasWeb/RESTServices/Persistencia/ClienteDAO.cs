using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using RESTServices.Dominio;

namespace RESTServices.Persistencia
{
    public class ClienteDAO
    {
        public Cliente ConsultarCliente(string dni)
        {
            Cliente clienteEncontrado = null;
            string sql = "SELECT * FROM cliente WHERE dni = @dni";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@dni", dni));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            clienteEncontrado = new Cliente()
                            {
                                dnicliente = (string)resultado["dnicliente"],
                                nombrecliente = (string)resultado["nombrecliente"],
                                apellidopaterno = (string)resultado["apellidopaterno"],
                                apellidomaterno = (string)resultado["apellidomaterno"],
                                correo = (string)resultado["correo"],
                                direccioncliente = (string)resultado["direccioncliente"]
                            };
                        }
                    }
                }

            } return clienteEncontrado;
        }
    }
}