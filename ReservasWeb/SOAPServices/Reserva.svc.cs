using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Persistencia;

namespace SOAPServices
{
   
    public class Reserva : IReserva{

        private ReservaDAO reservaDAO = null;

        private ReservaDAO ReservaDAO{

            get
            {
                if (reservaDAO == null)
                    reservaDAO = new ReservaDAO();
                return reservaDAO;
            }
        }


        public List<Reserva> ListarReservas()
        {
            //return ReservaDAO.ListarTodos().ToList();
            return null;
        }


        public void EliminarReserva(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
