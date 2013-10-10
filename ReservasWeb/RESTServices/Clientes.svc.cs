using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Persistencia;
using RESTServices.Dominio;

namespace RESTServices
{
    public class Clientes : ICliente
    {
        private ClienteDAO dao = new ClienteDAO();

        public Cliente ObtenerCliente(string dni)
        {
            return dao.ConsultarCliente(dni);
        }
    }
}
