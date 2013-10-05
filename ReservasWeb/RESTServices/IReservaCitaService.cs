using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using RESTServices.Dominio;

namespace RESTServices
{
    [ServiceContract]
    public interface IReservaCitaService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "ReservaAnular", ResponseFormat = WebMessageFormat.Json)]
        ReservaCita AnularReserva(ReservaCita reservaCita);
    }
}
