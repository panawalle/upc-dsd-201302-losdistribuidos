using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;
using System.Net;
using System.ServiceModel.Web;

namespace RESTServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReservaCitaService" in code, svc and config file together.
    public class ReservaCitaService : IReservaCitaService
    {
        private ReservaCitaDAO dao = new ReservaCitaDAO();

        public ReservaCita AnularReserva(ReservaCita reservaCita)
        {
            ReservaCita beanReserva = dao.Obtener(reservaCita);
            if (beanReserva != null)
            {
                // Validacion Cita : estado "Atendido"
                if(beanReserva.estado == "2")
                {
                    throw new WebFaultException<ExcepcionError>(new ExcepcionError() { msjValidacion = "El codigo de Reserva " + beanReserva.codigo + " tiene Estado Atendido. No se podra Anular Reserva." }, HttpStatusCode.InternalServerError);
                } // Validacion Cita : estado "Anulado"
                else if (beanReserva.estado == "1")
                {
                    throw new WebFaultException<ExcepcionError>(new ExcepcionError() { msjValidacion = "El codigo de Reserva " + beanReserva.codigo + " ya tiene Estado Anulado." }, HttpStatusCode.InternalServerError);
                }
                else 
                {
                    beanReserva = dao.Anular(reservaCita);
                }
            }
            else
            { // Validacion Cita : No existe
                throw new WebFaultException<ExcepcionError>(new ExcepcionError() { msjValidacion = "El codigo de Reserva " + reservaCita.nroreserva + " no Existe." }, HttpStatusCode.InternalServerError);
            }

            return beanReserva;
        }
    }
}
