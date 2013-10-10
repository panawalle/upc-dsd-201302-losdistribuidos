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
    public interface ICliente
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Clientes/{dni}", ResponseFormat = WebMessageFormat.Json)]
        Cliente ObtenerCliente(string dni);   
    }
}
