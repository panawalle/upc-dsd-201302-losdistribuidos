using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RESTServices.Dominio;
using System.Data.SqlClient;

namespace RESTServices.Persistencia
{
    public class VehiculoDAO
    {
       
        public Vehiculo Obtener(string placa)
        {
            Vehiculo vehiculoEncontrado = new Vehiculo();
            string sql = "SELECT V.PLACA AS PLACA, V.VIN AS VIN, V.MOTOR AS MOTOR, V.ANIO AS ANIO, V.CODCOLOR AS CODCOLOR,";
            sql += " V.CODMODELO AS CODMODELO, V.CONTACTO AS CONTACTO, V.USUARIO AS USUARIO, ";
            sql += " CL.NOMBRE AS NOMCLI, MO.DESCRIPCION DESCMODELO, CO.DESCRIPCION DESCCOLOR ";
            sql += " FROM VEHICULO V ";
            sql += " LEFT JOIN CLIENTE CL ON V.CODCLIENTE = CL.CODCLIENTE ";
            sql += " LEFT JOIN MODELO MO ON V.CODMODELO = MO.CODMODELO ";
            sql += " LEFT JOIN COLOR CO ON V.CODCOLOR = CO.CODCOLOR ";
            sql += " WHERE V.PLACA = @placa ";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@placa", placa));
                    using (SqlDataReader resultado = com.ExecuteReader()) 
                    {
                        if (resultado.Read()) 
                        {
                            vehiculoEncontrado = new Vehiculo()
                            {
                                placa = (string)resultado["PLACA"],
                                vin = (string)resultado["VIN"],
                                motor = (string)resultado["MOTOR"],
                                anio = (string)resultado["ANIO"],
                                codColor = (string)resultado["CODCOLOR"],
                                codModelo = (string)resultado["CODMODELO"],
                                contacto = (string)resultado["CONTACTO"],
                                usuario = (string)resultado["USUARIO"],
                                nomCliente = (string)resultado["NOMCLI"],
                                descModelo = (string)resultado["DESCMODELO"],
                                descColor = (string)resultado["DESCCOLOR"]
                            };
                        }
                    }
                }

                return vehiculoEncontrado;
            
            }
        }

        public Vehiculo Crear(Vehiculo vehiculoACrear)
        {

            Vehiculo vehiculoCreado = new Vehiculo();
            string sql = "INSERT INTO VEHICULO(PLACA,VIN,ANIO,MOTOR,CONTACTO,USUARIO,CODCOLOR,CODMODELO,CODCLIENTE) VALUES(@placa, @vin, @anio, @motor, @contacto, @usuario, @codColor, @codModelo, @codCliente)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena()))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@placa", vehiculoACrear.placa));
                    com.Parameters.Add(new SqlParameter("@vin", vehiculoACrear.vin));
                    com.Parameters.Add(new SqlParameter("@anio", vehiculoACrear.anio));
                    com.Parameters.Add(new SqlParameter("@motor", vehiculoACrear.motor));
                    com.Parameters.Add(new SqlParameter("@contacto", vehiculoACrear.contacto));
                    com.Parameters.Add(new SqlParameter("@usuario", vehiculoACrear.usuario));
                    com.Parameters.Add(new SqlParameter("@codColor", vehiculoACrear.codColor));
                    com.Parameters.Add(new SqlParameter("@codModelo", vehiculoACrear.codModelo));
                    com.Parameters.Add(new SqlParameter("@codCliente", vehiculoACrear.codCliente));
                    com.ExecuteNonQuery();
                }
            }
            vehiculoCreado = Obtener(vehiculoACrear.placa);
            return vehiculoCreado;
        }


        public Vehiculo Modificar(Vehiculo vehiculoAModificar)
        {

            Vehiculo alumnoCreado = new Vehiculo();
            string sql = "UPDATE VEHICULO SET VIN = @vin, ANIO = @anio, MOTOR = @motor, CONTACTO = @contacto, USUARIO = @usuario WHERE PLACA = @placa";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena()))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@placa", vehiculoAModificar.placa));
                    com.Parameters.Add(new SqlParameter("@vin", vehiculoAModificar.vin));
                    com.Parameters.Add(new SqlParameter("@anio", vehiculoAModificar.anio));
                    com.Parameters.Add(new SqlParameter("@motor", vehiculoAModificar.motor));
                    com.Parameters.Add(new SqlParameter("@contacto", vehiculoAModificar.contacto));
                    com.Parameters.Add(new SqlParameter("@usuario", vehiculoAModificar.usuario));
                    com.ExecuteNonQuery();
                }
            }
            alumnoCreado = Obtener(vehiculoAModificar.placa);
            return alumnoCreado;
        }

 

        public Vehiculo Eliminar(Vehiculo vehiculoAEliminar)
        {
            string sql = "DELETE FROM VEHICULO WHERE PLACA = @placa";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena()))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@placa", vehiculoAEliminar.placa));
                    com.ExecuteNonQuery();
                }
            }

            Vehiculo vehEncontrado = new Vehiculo()
            {
                placa = (string)vehiculoAEliminar.placa
            };
            return vehEncontrado;
        }

        
        public List<Vehiculo> ListarVehiculos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            Vehiculo vehiculoEncontrado = new Vehiculo();
            //string sql = "SELECT PLACA, VIN, MOTOR, ANIO FROM VEHICULO";
            string sql = "SELECT V.PLACA AS PLACA, V.VIN AS VIN, V.MOTOR AS MOTOR, V.ANIO AS ANIO, V.CODCOLOR AS CODCOLOR,";
            sql += " V.CODMODELO AS CODMODELO, V.CONTACTO AS CONTACTO, V.USUARIO AS USUARIO, ";
            sql += " CL.NOMBRE AS NOMCLI, MO.DESCRIPCION DESCMODELO, CO.DESCRIPCION DESCCOLOR ";
            sql +=" FROM VEHICULO V ";
            sql +=" LEFT JOIN CLIENTE CL ON V.CODCLIENTE = CL.CODCLIENTE ";
            sql +=" LEFT JOIN MODELO MO ON V.CODMODELO = MO.CODMODELO ";
            sql +=" LEFT JOIN COLOR CO ON V.CODCOLOR = CO.CODCOLOR ";
            
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            vehiculoEncontrado = new Vehiculo()
                            {
                                placa = (string)resultado["PLACA"],
                                vin = (string)resultado["VIN"],
                                motor = (string)resultado["MOTOR"],
                                anio = (string)resultado["ANIO"],
                                codColor = (string)resultado["CODCOLOR"],
                                codModelo = (string)resultado["CODMODELO"],
                                contacto = (string)resultado["CONTACTO"],
                                usuario = (string)resultado["USUARIO"],
                                nomCliente = (string)resultado["NOMCLI"],
                                descModelo = (string)resultado["DESCMODELO"],
                                descColor = (string)resultado["DESCCOLOR"]
                            };
                            lista.Add(vehiculoEncontrado);
                        }
                    }
                }
            }

            return lista;
        }

    }
}