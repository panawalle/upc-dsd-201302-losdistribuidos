using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RESTServices.Dominio;
using System.Data.SqlClient;

namespace RESTServices.Persistencia
{
    public class ReservaCitaDAO
    {
        public ReservaCita Anular(ReservaCita reserva)
        {

            ReservaCita citaAnulada = null;
            string sql = "UPDATE RESERVA SET ESTADO ='1' WHERE CODRESERVA = @codReserva ";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena()))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@codReserva", reserva.nroreserva));
                    com.ExecuteNonQuery();
                }
            }

            citaAnulada = Obtener(reserva);
            return citaAnulada;
        }

        public ReservaCita Obtener(ReservaCita beanReserva)
        {
            ReservaCita reservaEncontrada = null;
            string sql = "SELECT CODRESERVA,NRORESERVA,PLACA,ESTADO FROM RESERVA WHERE CODRESERVA = @codigo";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@codigo", beanReserva.nroreserva));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            reservaEncontrada = new ReservaCita()
                            {
                                codigo = (int)resultado["CODRESERVA"],
                                nroreserva = (string)resultado["NRORESERVA"],
                                vehiculo = new Vehiculo { placa = (string)resultado["PLACA"] },
                                estado = (string)resultado["ESTADO"]
                            };
                        }
                    }
                }
            }
            return reservaEncontrada;
        }
    }
}