using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace SOAPServices.Negocio
{
    public class ReservaBLL
    {
        Persistencia.ReservaDAO objReservaDAO = new Persistencia.ReservaDAO();

        public Dominio.Reserva fnObtenerReserva(int codReserva) {
            return objReservaDAO.fnObtenerReserva(codReserva);
        }

        public Dominio.Reserva fnGuardarReserva(Dominio.Reserva objReserva) {

            return objReservaDAO.fnGuardarReserva(objReserva);
        }

       public List<Dominio.Reserva> fnListarReserva(int codReserva, string nroReserva, string placa, int codestado)
       {
            return objReservaDAO.fnListarReserva(codReserva,nroReserva,placa, codestado);
        }


    }
}