using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace SOAPServices
{
    public class Reserva : IReserva
    {

        Negocio.ReservaBLL objReservaBLL = new Negocio.ReservaBLL();

        public Dominio.Reserva fnObtenerReserva(int codReserva)
        {
            Dominio.Reserva objReserva = new Dominio.Reserva();

            objReserva = objReservaBLL.fnObtenerReserva(codReserva);

            return objReserva;
        }

        public Dominio.Reserva fnGuardarReserva(Dominio.Reserva objReserva)
        {
            Dominio.Reserva objReservaRegistrado = new Dominio.Reserva();

            objReservaRegistrado = objReservaBLL.fnGuardarReserva(objReserva);

            return objReservaRegistrado;

        }

        public List<Dominio.Reserva> fnListarReserva(int codReserva, string nroReserva, string placa)
        {
            List<Dominio.Reserva> objListReserva = new List<Dominio.Reserva>();

            objListReserva = objReservaBLL.fnListarReserva(codReserva, nroReserva, placa);

            return objListReserva;
        }
    }
}
