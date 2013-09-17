using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ReservasWeb.Persistencia;
using SOAPServices.Dominio;
using System.ServiceModel.Web;
using System.Net;

namespace SOAPServices {

  public class ClienteService : IClienteService {

    private ClienteDAO clienteDAO = null;
    private ClienteDAO ClienteDAO {
      get {
        if (clienteDAO == null)
          clienteDAO = new ClienteDAO();
        return clienteDAO;
      }
    }

    //Listado de los clientes en el sistema.
    public List<Cliente> ListarCliente() {
      return ClienteDAO.ListarTodos().ToList();
    }

    //Registro de clientes
    public Cliente RegistrarCliente(int codigo, string dni, int tipo, string nombre, string apellidopaterno, string apellidomaterno, string correo, string direccion, string telefono, string celular) {
      Cliente entCliente = new Cliente() {
        codigocliente = codigo,
        dnicliente = dni,
        tipo = tipo,
        nombrecliente = nombre,
        apellidopaterno = apellidopaterno,
        apellidomaterno = apellidomaterno,
        direccioncliente = direccion,
        telefono = telefono,
        celular = celular,
        correo = correo
      };
      return ClienteDAO.Crear(entCliente);
    }

    //Obtener Cliente
    public Cliente ObtenerCliente(int codigo) {
      return ClienteDAO.Obtener(codigo);
    }

    //Modificar Cliente
    public Cliente ModificarCliente(int codigo, string dni, int tipo, string nombre, string apellidopaterno, string apellidomaterno, string correo, string direccion, string telefono, string celular) {
      Cliente clienteCrear = new Cliente() {
        codigocliente = codigo,
        dnicliente = dni,
        tipo = tipo,
        nombrecliente = nombre,
        apellidopaterno = apellidopaterno,
        apellidomaterno = apellidomaterno,
        direccioncliente = direccion,
        telefono = telefono,
        celular = celular,
        correo = correo
      };
      return ClienteDAO.Modificar(clienteCrear);
    }

    //Eliminar Cliente
    public void Eliminar(int codigo) {
      Cliente asesorExistente = ClienteDAO.Obtener(1);
      ClienteDAO.Eliminar(asesorExistente);
    }

  }
}
