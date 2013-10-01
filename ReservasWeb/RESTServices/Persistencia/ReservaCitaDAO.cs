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

            ReservaCita citaAnulada = new ReservaCita();
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
            
            citaAnulada = new ReservaCita(){
                nroreserva = (string)reserva.nroreserva
            };
            // citaAnulada = Obtener(vehiculoACrear.placa);
            return citaAnulada;
        }
    }
}