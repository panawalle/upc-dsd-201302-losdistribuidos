using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReservasWeb.Models;

namespace ReservasWeb.Controllers
{
    public class VehiculoController : Controller
    {
        private List<Vehiculo> CrearVehiculos() {
             Departamento LimaDepa = new Departamento() { codigodepartamento = 1, nombredepartamento = "Lima" };
      Departamento CuscoDepa = new Departamento() { codigodepartamento = 2, nombredepartamento = "Cusco" };

      Provincia LimaProv = new Provincia() { codigoprovincia = 1, nombreprovincia = "Lima" };
      Provincia UrubambaProv = new Provincia() { codigoprovincia = 2, nombreprovincia = "Urubamba" };

      Distrito LimaDis = new Distrito() { codigodistrito = 1, nombredistrito = "Lima" };
      Distrito OllantaytamboDis = new Distrito() { codigodistrito = 2, nombredistrito = "Ollantaytambo" };

      List<Cliente> clientes = new List<Cliente>();
      clientes.Add(new Cliente() { dnicliente = "44513804", nombrecliente = "Lesly", apellidocliente = "Ormeño", correocliente = "lesly.varillas@gmail.com", sexocliente = "F", fecnacliente = "12/10/1990", distritocliente = LimaDis, provinciacliente = LimaProv, departamentocliente = LimaDepa });
      clientes.Add(new Cliente() { dnicliente = "43781265", nombrecliente = "Oscar", apellidocliente = "Santillan", correocliente = "oscar@gmail.com", sexocliente = "M", fecnacliente = "15/08/1985", distritocliente = OllantaytamboDis, provinciacliente = UrubambaProv, departamentocliente = CuscoDepa });

            Vehiculo vehiculo = new Vehiculo() {placa =""}
        
        }


        //
        // GET: /Vehiculo/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Vehiculo/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Vehiculo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Vehiculo/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Vehiculo/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Vehiculo/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Vehiculo/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Vehiculo/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
