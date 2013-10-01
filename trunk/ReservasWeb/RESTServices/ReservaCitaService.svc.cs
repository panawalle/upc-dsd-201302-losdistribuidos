using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;

namespace RESTServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReservaCitaService" in code, svc and config file together.
    public class ReservaCitaService : IReservaCitaService
    {
        private ReservaCitaDAO dao = new ReservaCitaDAO();

        public ReservaCita AnularReserva(ReservaCita reservaCita)
        {
            return dao.Anular(reservaCita);
        }
    }
}
