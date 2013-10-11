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
        public List<Cliente> ListarTodos()
        {
            Cliente clienteEncontrado = null;
            List<Cliente> Listado = new List<Cliente>();
            string sql = "SELECT * FROM cliente";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    //com.Parameters.Add(new SqlParameter("@dni", dni));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            clienteEncontrado = new Cliente()
                            {
                              
                                apellidopaterno = (string)resultado["apellidopaterno"],
                                apellidomaterno = (string)resultado["apellidomaterno"],
                                
                            };
                            Listado.Add(clienteEncontrado);
                        }
                    }
                }

            } return Listado;
        }

        public Cliente ObtenerXCodigo(int p_codigo)
        {
            Cliente clienteEncontrado = null;
            string sql = "SELECT documento FROM cliente WHERE codCliente = @codigo";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@codigo", p_codigo)); 
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            clienteEncontrado = new Cliente()
                            {
                                dnicliente = (string)resultado["documento"]
                                /*
                                codigocliente = (int)resultado["codCliente"],
                                dnicliente = (string)resultado["documento"],
                                nombrecliente = (string)resultado["nombre"],
                                apellidopaterno = (string)resultado["apellidopaterno"],
                                apellidomaterno = (string)resultado["apellidomaterno"],
                                correo = (string)resultado["email"],
                                direccioncliente = (string)resultado["direccion"]
                                */
                            };
                        }
                    }
                }

            } 
            return clienteEncontrado;
        }


    }
}