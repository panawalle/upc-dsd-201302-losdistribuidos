using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReservasWeb.Controllers;
using ReservasWeb.SOAPClientes;

namespace ReservasWeb.Controllers
{

    /// Creado por: Lesly Ormeño
    /// Modificado por: Lesly Ormeño 
    /// Fecha de Creación: 07/09/13
    /// Fedha de Actualización: 07/09/13
    /// Comentarios: Se realizó la creación de métodos para el CRUD, sin base de datos.

    public class ClienteController : Controller
    {

        SOAPClientes.Cliente clienteCreado = null;

     
        public ActionResult Index()
        {
            SOAPClientes.ClienteServiceClient proxy = new SOAPClientes.ClienteServiceClient();
            List<SOAPClientes.Cliente> coleccion = proxy.ListarCliente().ToList();
            return null;
        }

        private Cliente ObtenerCliente(string dni)
        {
            List<Cliente> listClientes = (List<Cliente>)Session["clientes"];
            Cliente model = listClientes.Single(delegate(Cliente cliente)
            {
                if (cliente.dnicliente == dni) return true;
                else return false;
            });
            return model;

        }

        public ActionResult Details(string id)
        {
            Cliente cli = ObtenerCliente(id);
            return View(cli);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                SOAPClientes.ClienteServiceClient asesoresWS = new SOAPClientes.ClienteServiceClient();
                clienteCreado = asesoresWS.RegistrarCliente(int.Parse(collection["codigocliente"]), (string)collection["dniCliente"], int.Parse(collection["tipo"]), (string)(collection["nombrecliente"]), (string)(collection["apellidopaterno"]), (string)(collection["apellidomaterno"]), (string)(collection["correo"]), (string)collection["direccioncliente"], (string)(collection["telefono"]), (string)(collection["celular"]));
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                if (e.Message == "Bad Request")
                    ModelState.AddModelError(String.Empty, "Error: Hay datos vacios o nulos.");

                if (e.Message == "Not Acceptable")
                    ModelState.AddModelError(String.Empty, "Error: DNI o EMAil ya esta registrado.");
                return View();
            }
        }

        public ActionResult Edit(string id)
        {
            Cliente cliente = ObtenerCliente(id);
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Edit(string id, Cliente cliente)
        {
            try
            {
                Cliente cli = ObtenerCliente(id);
                cli.nombrecliente = cliente.nombrecliente;
                cli.correo = cliente.correo;
                cli.apellidomaterno = cliente.apellidopaterno;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(string id)
        {
            Cliente cliente = ObtenerCliente(id);
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                List<Cliente> listCliente = (List<Cliente>)Session["clientes"];
                listCliente.Remove(ObtenerCliente(id));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
