using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReservasWeb.Models;

namespace ReservasWeb.Controllers
{
    public class OportunidadController : Controller {
        public List<OportunidadVenta> CrearOportunidad()
        {
  
      List<OportunidadVenta> oportunidades = new List<OportunidadVenta>();
      oportunidades.Add(new OportunidadVenta() { codServicio = "SER0001", nombreServicio = "Arandela de tapón", cantidadServicio = "1", precioServicio = "12.45" });
      oportunidades.Add(new OportunidadVenta() { codServicio = "SER0002", nombreServicio = "Filtro de aceite", cantidadServicio = "2", precioServicio = "15.45" });
      return oportunidades;
    }

     private OportunidadVenta ObtenerCliente(string codServic)
        {
        List<OportunidadVenta> listClientes = (List<OportunidadVenta>)Session["oportunidades"];
        OportunidadVenta model = listClientes.Single(delegate(OportunidadVenta cliente)
        {
            if (cliente.codServicio == codServic) return true;
        else return false;
      });
      return model;

    }

    public ActionResult Index() {
      if (Session["oportunidades"] == null)
          Session["oportunidades"] = CrearOportunidad();
      List<OportunidadVenta> model = (List<OportunidadVenta>)Session["oportunidades"];
      return View(model);

    }

    public ActionResult Details(string id) {
        OportunidadVenta cli = ObtenerCliente(id);
      return View(cli);
    }

    public ActionResult Create() {
      return View();
    }

    [HttpPost]
    public ActionResult Create(OportunidadVenta oport)
    {
      try {
          List<OportunidadVenta> listOport = (List<OportunidadVenta>)Session["oportunidades"];
          listOport.Add(oport);

        return RedirectToAction("Index");
      } catch {
        return View();
      }
    }
  
    public ActionResult Edit(string id) {
        OportunidadVenta oport = ObtenerCliente(id);
      return View(oport);
    }

   [HttpPost]
    public ActionResult Edit(string id, OportunidadVenta cliente)
    {
      try {
          OportunidadVenta cli = ObtenerCliente(id);
          cli.nombreServicio = cliente.nombreServicio;
          cli.cantidadServicio = cliente.cantidadServicio;
          cli.precioServicio = cliente.precioServicio;

        return RedirectToAction("Index");
      } catch {
        return View();
      }
    }

    public ActionResult Delete(string id) {
        OportunidadVenta cliente = ObtenerCliente(id);
      return View(cliente);
    }

    [HttpPost]
    public ActionResult Delete(string id, FormCollection collection) {
      try {
          List<OportunidadVenta> listCliente = (List<OportunidadVenta>)Session["oportunidades"];
        listCliente.Remove(ObtenerCliente(id));

        return RedirectToAction("Index");
      } catch {
        return View();
      }
    }
  }
}
