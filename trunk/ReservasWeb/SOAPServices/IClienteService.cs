using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices {

  [ServiceContract]
  public interface IClienteService {

    [OperationContract]
      Cliente RegistrarCliente(int codigo, string dni, int tipo, string nombre, string apellidopaterno, string apellidomaterno, string correo, string direccion, string telefono, string celular);

    [OperationContract]
    Cliente ObtenerCliente(int codigo);

    [OperationContract]
    Cliente ModificarCliente(int codigo, string dni, int tipo, string nombre, string apellidopaterno, string apellidomaterno, string correo, string direccion, string telefono, string celular);

    [OperationContract]
    void Eliminar(int codigo);

    [OperationContract]
    List<Cliente> ListarCliente();

  }
}
