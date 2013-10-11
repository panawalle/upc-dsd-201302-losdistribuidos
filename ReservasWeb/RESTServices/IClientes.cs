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
    public interface IClientes
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Clientes", ResponseFormat = WebMessageFormat.Json)]
        List<Cliente> ListarClientes();  
    }
}
