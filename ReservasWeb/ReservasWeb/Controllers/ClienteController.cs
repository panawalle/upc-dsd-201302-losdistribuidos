using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReservasWeb.Models;

namespace ReservasWeb.Controllers {
  public class ClienteController : Controller {
    //
    // GET: /Cliente/

    public List<Cliente> CrearClientes() {
      Departamento LimaDe = new Departamento() { codigodepartamento = 1, nombredepartamento = "Lima" };
      Departamento Cusco = new Departamento() { codigodepartamento = 2, nombredepartamento = "Cusco" };

      Provincia LimaPro = new Provincia() { codigoprovincia = 1, nombreprovincia = "Lima" };
      Provincia Urubamba = new Provincia() { codigoprovincia = 2, nombreprovincia = "Urubamba" };

      Distrito LimaDi = new Distrito() { codigodistrito = 1, nombredistrito = "Lima" };
      Distrito Ollantaytambo = new Distrito() { codigodistrito = 2, nombredistrito = "Ollantaytambo" };

      List<Cliente> clientes = new List<Cliente>();
      clientes.Add(new Cliente() { dnicliente = "44513804", nombrecliente = "Lesly", apellidocliente = "Ormeño", correocliente = "lesly.varillas@gmail.com", sexocliente = "F", fecnacliente = "12/10/1990", distritocliente = "Lima", provinciacliente = "Lima", departamentocliente = "Lima" });
      clientes.Add(new Cliente() { dnicliente = "43781265", nombrecliente = "Oscar", apellidocliente = "Santillan", correocliente = "oscar@gmail.com", sexocliente = "M", fecnacliente = "15/08/1985", distritocliente = "Ollantaytambo", provinciacliente = "Urubamba", departamentocliente = "Cusco" });
      return clientes;
    }

    private Cliente ObtenerCliente(string dni) {
      List<Cliente> listClientes = (List<Cliente>)Session["clientes"];
      Cliente model = listClientes.Single(delegate(Cliente cliente) {
        if (cliente.dnicliente == dni) return true;
        else return false;
      });
      return model;

    }

    public ActionResult Index() {
      if (Session["clientes"] == null)
        Session["clientes"] = CrearClientes();
      List<Cliente> model = (List<Cliente>)Session["clientes"];
      return View(model);

    }

    //
    // GET: /Cliente/Details/5

    public ActionResult Details(string id) {
      Cliente cli = ObtenerCliente(id);
      return View(cli);
    }

    //
    // GET: /Cliente/Create

    public ActionResult Create() {
      return View();
    }

    //
    // POST: /Cliente/Create

    [HttpPost]
    public ActionResult Create(Cliente cliente) {
      try {
        List<Cliente> listCliente = (List<Cliente>)Session["clientes"];
        listCliente.Add(cliente);

        return RedirectToAction("Index");
      } catch {
        return View();
      }
    }

    //
    // GET: /Cliente/Edit/5

    public ActionResult Edit(string id) {
      Cliente cliente = ObtenerCliente(id);
      return View(cliente);
    }

    //
    // POST: /Cliente/Edit/5

    [HttpPost]
    public ActionResult Edit(string id, Cliente cliente) {
      try {
        Cliente cli = ObtenerCliente(id);
        cli.nombrecliente = cliente.nombrecliente;
        cli.correocliente = cliente.correocliente;
        cli.apellidocliente = cliente.apellidocliente;

        return RedirectToAction("Index");
      } catch {
        return View();
      }
    }

    //
    // GET: /Cliente/Delete/5

    public ActionResult Delete(string id) {
      Cliente cliente = ObtenerCliente(id);
      return View(cliente);
    }

    //
    // POST: /Cliente/Delete/5

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
