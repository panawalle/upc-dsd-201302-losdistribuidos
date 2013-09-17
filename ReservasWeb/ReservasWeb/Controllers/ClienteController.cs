using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReservasWeb.Controllers;
using ReservasWeb.SOAPClientes;

namespace ReservasWeb.Controllers {

  /// Creado por: Lesly Ormeño
  /// Modificado por: Lesly Ormeño 
  /// Fecha de Creación: 07/09/13
  /// Fedha de Actualización: 07/09/13
  /// Comentarios: Se realizó la creación de métodos para el CRUD, sin base de datos.

  public class ClienteController : Controller {

    SOAPClientes.Cliente clienteCreado = null;

  //public List<Cliente> CrearClientes() {
  //    Departamento LimaDe = new Departamento() { codigodepartamento = 1, nombredepartamento = "Lima" };
  //    Departamento Cusco = new Departamento() { codigodepartamento = 2, nombredepartamento = "Cusco" };

  //    Provincia LimaPro = new Provincia() { codigoprovincia = 1, nombreprovincia = "Lima" };
  //    Provincia Urubamba = new Provincia() { codigoprovincia = 2, nombreprovincia = "Urubamba" };

  //    Distrito LimaDi = new Distrito() { codigodistrito = 1, nombredistrito = "Lima" };
  //    Distrito Ollantaytambo = new Distrito() { codigodistrito = 2, nombredistrito = "Ollantaytambo" };

  //    List<Cliente> clientes = new List<Cliente>();
  //    clientes.Add(new Cliente() { dnicliente = "44513804", nombrecliente = "Lesly", apellidocliente = "Ormeño", correo = "lesly.varillas@gmail.com", sexocliente = "F", fechaNacimientoCliente = "12/10/1990", distritocliente = LimaDi, provinciacliente = LimaPro, departamentocliente = LimaDe });
  //    clientes.Add(new Cliente() { dnicliente = "43781265", nombrecliente = "Oscar", apellidocliente = "Santillan", correo = "oscar@gmail.com", sexocliente = "M", fechaNacimientoCliente = "15/08/1985", distritocliente = LimaDi, provinciacliente = LimaPro, departamentocliente = LimaDe });
  //    return clientes;
  //  }

    private Cliente ObtenerCliente(string dni) {
      List<Cliente> listClientes = (List<Cliente>)Session["clientes"];
      Cliente model = listClientes.Single(delegate(Cliente cliente) {
        if (cliente.dnicliente == dni) return true;
        else return false;
      });
      return model;

    }

    public ActionResult Index() {
      //if (Session["clientes"] == null)
      //  Session["clientes"] = CrearClientes();
      //List<Cliente> model = (List<Cliente>)Session["clientes"];
      //return View(model);
      SOAPClientes.ClienteServiceClient proxy = new SOAPClientes.ClienteServiceClient();
      List<SOAPClientes.Cliente> coleccion = proxy.ListarCliente().ToList();
      return View(coleccion);
    }

    public ActionResult Details(string id) {
      Cliente cli = ObtenerCliente(id);
      return View(cli);
    }

    public ActionResult Create() {
      return View();
    }

    [HttpPost]
    public ActionResult Create(FormCollection collection) {
      try {
        SOAPClientes.ClienteServiceClient asesoresWS = new SOAPClientes.ClienteServiceClient();
        clienteCreado = asesoresWS.RegistrarCliente(int.Parse(collection["codigocliente"]),(string)collection["dniCliente"], int.Parse(collection["tipo"]), (string)(collection["nombrecliente"]), (string)(collection["apellidopaterno"]), (string)(collection["apellidomaterno"]), (string)(collection["correo"]), (string)collection["direccioncliente"], (string)(collection["telefono"]), (string)(collection["celular"]));
        return RedirectToAction("Index");

        return View("Registrado");
      } catch (Exception e) {
        if (e.Message == "Bad Request")
          ModelState.AddModelError(String.Empty, "Error: Hay datos vacios o nulos.");

        if (e.Message == "Not Acceptable")
          ModelState.AddModelError(String.Empty, "Error: DNI o EMAil ya esta registrado.");
        return View();
      }
    }

    public ActionResult Edit(string id) {
      Cliente cliente = ObtenerCliente(id);
      return View(cliente);
    }

    [HttpPost]
    public ActionResult Edit(string id, Cliente cliente) {
      try {
        Cliente cli = ObtenerCliente(id);
        cli.nombrecliente = cliente.nombrecliente;
        cli.correo = cliente.correo;
        cli.apellidomaterno = cliente.apellidopaterno;

        return RedirectToAction("Index");
      } catch {
        return View();
      }
    }

    public ActionResult Delete(string id) {
      Cliente cliente = ObtenerCliente(id);
      return View(cliente);
    }

    [HttpPost]
    public ActionResult Delete(string id, FormCollection collection) {
      try {
        List<Cliente> listCliente = (List<Cliente>)Session["clientes"];
        listCliente.Remove(ObtenerCliente(id));

        return RedirectToAction("Index");
      } catch {
        return View();
      }
    }
  }
}
