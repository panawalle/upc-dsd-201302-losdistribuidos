﻿using System;
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
            List<Cliente> proxyProductos = proxy.ListarCliente().ToList();
            List<Models.Cliente> listaProducto = new List<Models.Cliente>();

            foreach (Cliente item in proxyProductos)
            {
                Models.Cliente item2 = new Models.Cliente();
                item2.codigocliente = item.codigocliente;
                item2.dnicliente = item.dnicliente;
                item2.nombrecliente = item.nombrecliente;
                item2.apellidopaterno = item.apellidopaterno;
                item2.apellidomaterno = item.apellidomaterno;
                item2.direccioncliente = item.direccioncliente;
                item2.correo = item.correo;
                item2.telefono = item.telefono;
                item2.celular = item.celular;

                listaProducto.Add(item2);
            }
            return View(listaProducto);

            //SOAPClientes.ClienteServiceClient proxy = new SOAPClientes.ClienteServiceClient();
            //ICollection<Cliente> modelo = proxy.ListarCliente();
            //return View(modelo);
        }

        private Cliente ObtenerCliente(int collection)
        {
            SOAPClientes.ClienteServiceClient asesoresWS = new SOAPClientes.ClienteServiceClient();
            clienteCreado = asesoresWS.ObtenerCliente(collection);
            return clienteCreado;
        }

        public ActionResult Details(int id)
        {
            SOAPClientes.ClienteServiceClient proxy = new SOAPClientes.ClienteServiceClient();
            SOAPClientes.Cliente usuarioBuscado = proxy.ObtenerCliente(id);
            Models.Cliente cliente = new Models.Cliente()
            {
                dnicliente = usuarioBuscado.dnicliente,
                nombrecliente = usuarioBuscado.nombrecliente,
                apellidopaterno = usuarioBuscado.apellidopaterno,
                apellidomaterno = usuarioBuscado.apellidomaterno,
                direccioncliente = usuarioBuscado.direccioncliente,
                telefono = usuarioBuscado.telefono,
                celular = usuarioBuscado.celular,
                correo = usuarioBuscado.correo
            };

            return View(cliente);
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

        public ActionResult Edit(int id)
        {
            SOAPClientes.ClienteServiceClient proxy = new SOAPClientes.ClienteServiceClient();
            SOAPClientes.Cliente clienteBuscado = proxy.ObtenerCliente(id);

            Models.Cliente cliente = new Models.Cliente()
            {
                codigocliente = clienteBuscado.codigocliente,
                dnicliente = clienteBuscado.dnicliente,
                nombrecliente = clienteBuscado.nombrecliente,
                apellidopaterno = clienteBuscado.apellidopaterno,
                apellidomaterno = clienteBuscado.apellidomaterno,
                direccioncliente = clienteBuscado.direccioncliente,
                telefono = clienteBuscado.telefono,
                celular = clienteBuscado.celular,
                correo = clienteBuscado.correo
            };
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Cliente cli = ObtenerCliente(id);
                SOAPClientes.ClienteServiceClient asesoresWS = new SOAPClientes.ClienteServiceClient();
                clienteCreado = asesoresWS.ModificarCliente(int.Parse(collection["codigocliente"]), (string)collection["dnicliente"], 1, (string)collection["nombrecliente"], (string)collection["apellidopaterno"], (string)collection["apellidomaterno"], (string)collection["correo"], (string)collection["direccioncliente"], (string)collection["telefono"], (string)collection["celular"]);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            SOAPClientes.ClienteServiceClient proxy = new SOAPClientes.ClienteServiceClient();
            SOAPClientes.Cliente usuarioBuscado = proxy.ObtenerCliente(id);

            Models.Cliente cliente = new Models.Cliente()
            {
                codigocliente = usuarioBuscado.codigocliente,
                dnicliente = usuarioBuscado.dnicliente,
                nombrecliente = usuarioBuscado.nombrecliente,
                apellidopaterno = usuarioBuscado.apellidopaterno,
                apellidomaterno = usuarioBuscado.apellidomaterno,
                direccioncliente = usuarioBuscado.direccioncliente,
                telefono = usuarioBuscado.telefono,
                celular = usuarioBuscado.celular,
                correo = usuarioBuscado.correo
            };
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                SOAPClientes.ClienteServiceClient asesoresWS = new SOAPClientes.ClienteServiceClient();
                asesoresWS.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
