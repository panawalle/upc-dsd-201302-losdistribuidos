using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;
using System.ServiceModel.Web;

namespace RESTServices
{
    public class Reserva : IReserva
    {
        private ReservaDAO objReservaDAO = new ReservaDAO();

        public Dominio.Reserva fnObtenerReserva(string codReserva)
        {
            Dominio.Reserva objReservaResult = new Dominio.Reserva();
            int intCodReserva;

            try
            {
                intCodReserva = Convert.ToInt32(codReserva);
                objReservaResult = objReservaDAO.fnObtenerReserva(intCodReserva);
            }
            catch (Exception)
            {

                throw new WebFaultException<Error>(new Error() { strMensaje = objReservaResult.strMensaje }, System.Net.HttpStatusCode.BadRequest);
            }

            return objReservaResult;
        }

        public Dominio.Reserva fnGuardarReserva(Dominio.Reserva objReserva)
        {
            Dominio.Reserva objReservaResult = new Dominio.Reserva();
            try
            {
                objReservaResult = objReservaDAO.fnGuardarReserva(objReserva);

            }
            catch (Exception)
            {
                throw new WebFaultException<Error>(new Error() { strMensaje = objReservaResult.strMensaje }, System.Net.HttpStatusCode.BadRequest);
            }
            return objReservaResult;
        }

        public List<Dominio.Reserva> fnListarReserva(string codReserva, string nroReserva, string placa)
        {
            List<Dominio.Reserva> objReservaResult = new List<Dominio.Reserva>();
            int intCodReserva = Convert.ToInt32(codReserva);

            objReservaResult = objReservaDAO.fnListarReserva(intCodReserva, nroReserva, placa);
            
            return objReservaResult;
        }
    }
}
