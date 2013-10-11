using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace RESTServices
{
    [ServiceContract]
    public interface IReserva
    {
        [OperationContract]
        [WebInvoke(Method="GET",UriTemplate="Reservas/{codReserva}", ResponseFormat=WebMessageFormat.Json)]
        Dominio.Reserva fnObtenerReserva(string codReserva);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Reservas", ResponseFormat = WebMessageFormat.Json)]
        Dominio.Reserva fnGuardarReserva(Dominio.Reserva objReserva);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "ReservasA/{codReserva}", ResponseFormat = WebMessageFormat.Json)]
        Dominio.Reserva AnularReserva(string codReserva);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ReservasList/{codReserva},{nroReserva},{placa},{codestado}", ResponseFormat = WebMessageFormat.Json)]
        List<Dominio.Reserva> fnListarReserva(string codReserva="0", string nroReserva="0", string placa="0", string codestado = "-1");
    }
}
