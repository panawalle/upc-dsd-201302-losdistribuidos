using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReservasWeb.Models;

namespace ReservasWeb.Controllers
{
    public class OportunidadController : Controller {
        public List<Oportunidad> CrearOportunidad()
        {
  
      List<Oportunidad> oportunidades = new List<Oportunidad>();
      oportunidades.Add(new Oportunidad() { codServicio = "SER0001", nombreServicio = "Arandela de tapón", cantidadServicio = "1", precioServicio = "12.45" });
      oportunidades.Add(new Oportunidad() { codServicio = "SER0002", nombreServicio = "Filtro de aceite", cantidadServicio = "2", precioServicio = "15.45" });
      return oportunidades;
    }

     private Oportunidad ObtenerCliente(string codServic)
        {
        List<Oportunidad> listClientes = (List<Oportunidad>)Session["oportunidades"];
        Oportunidad model = listClientes.Single(delegate(Oportunidad cliente)
        {
            if (cliente.codServicio == codServic) return true;
        else return false;
      });
      return model;

    }

    public ActionResult Index() {
      if (Session["oportunidades"] == null)
          Session["oportunidades"] = CrearOportunidad();
      List<Oportunidad> model = (List<Oportunidad>)Session["oportunidades"];
      return View(model);

    }

    public ActionResult Details(string id) {
        Oportunidad cli = ObtenerCliente(id);
      return View(cli);
    }

    public ActionResult Create() {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Oportunidad oport)
    {
      try {
          List<Oportunidad> listOport = (List<Oportunidad>)Session["oportunidades"];
          listOport.Add(oport);

        return RedirectToAction("Index");
      } catch {
        return View();
      }
    }
  
    public ActionResult Edit(string id) {
        Oportunidad oport = ObtenerCliente(id);
      return View(oport);
    }

   [HttpPost]
    public ActionResult Edit(string id, Oportunidad cliente)
    {
      try {
          Oportunidad cli = ObtenerCliente(id);
          cli.nombreServicio = cliente.nombreServicio;
          cli.cantidadServicio = cliente.cantidadServicio;
          cli.precioServicio = cliente.precioServicio;

        return RedirectToAction("Index");
      } catch {
        return View();
      }
    }

    public ActionResult Delete(string id) {
        Oportunidad cliente = ObtenerCliente(id);
      return View(cliente);
    }

    [HttpPost]
    public ActionResult Delete(string id, FormCollection collection) {
      try {
          List<Oportunidad> listCliente = (List<Oportunidad>)Session["oportunidades"];
        listCliente.Remove(ObtenerCliente(id));

        return RedirectToAction("Index");
      } catch {
        return View();
      }
    }
  }
}
