using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Persistencia;
using RESTServices.Dominio;
using System.Messaging;

namespace RESTServices
{
    public class Clientes : IClientes
    {
        private ClienteDAO dao = new ClienteDAO();

        public List<Cliente> ListarClientes()
        {
            //string rutaCola = @".\private$\lormeno";
            //if (!MessageQueue.Exists(rutaCola))
            //    MessageQueue.Create(rutaCola);
            //MessageQueue cola = new MessageQueue(rutaCola);
            //cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(Cliente) });
            //Message[] mensajesenCola = cola.GetAllMessages();

            //foreach (Message msg in mensajesenCola)
            //{
            //    Message mensaje = msg;
            //    mensaje = cola.Receive();
            //}

            //Listar todos los clientes

            return dao.ListarTodos();
        }
    }
}
