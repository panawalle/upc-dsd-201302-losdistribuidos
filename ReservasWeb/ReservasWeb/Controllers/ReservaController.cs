using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReservasWeb.Models;

namespace ReservasWeb.Controllers
{
    public class ReservaController : Controller
    {
        private List<Reserva> CrearReservas()
        {
            Asesor  asesor1 = new Asesor() { codigo = 1, nombre ="Lorena Cermeño" };
            Asesor asesor2 = new Asesor() { codigo = 2, nombre = "Luis Cabañas" };

            Departamento LimaDe = new Departamento() { codigodepartamento = 1, nombredepartamento = "Lima" };
            Departamento Cusco = new Departamento() { codigodepartamento = 2, nombredepartamento = "Cusco" };

            Provincia LimaPro = new Provincia() { codigoprovincia = 1, nombreprovincia = "Lima" };
            Provincia Urubamba = new Provincia() { codigoprovincia = 2, nombreprovincia = "Urubamba" };

            Distrito LimaDi = new Distrito() { codigodistrito = 1, nombredistrito = "Lima" };
            Distrito Ollantaytambo = new Distrito() { codigodistrito = 2, nombredistrito = "Ollantaytambo" };

            Cliente cliente1 = new Cliente() { dnicliente = "44513804", nombrecliente = "Lesly", apellidocliente = "Ormeño", correocliente = "lesly.varillas@gmail.com", sexocliente = "F", fecnacliente = "12/10/1990", distritocliente = LimaDi  , provinciacliente = LimaPro , departamentocliente = LimaDe  };
            Cliente cliente2 = new Cliente() { dnicliente = "43781265", nombrecliente = "Oscar", apellidocliente = "Santillan", correocliente = "oscar@gmail.com", sexocliente = "M", fecnacliente = "15/08/1985", distritocliente = Ollantaytambo, provinciacliente = Urubamba, departamentocliente = Cusco  };

            Color color1 = new Color() { codigo = 1, descripcion = "Ladrillo", estado = "A" };
            Color color2 = new Color() { codigo = 2, descripcion = "Azul", estado = "A" };

            Marca marca1 = new Marca() { codigo = 1, descripcion = "Hyundai", estado = "A" };
            Marca marca2 = new Marca() { codigo = 2, descripcion = "Kia", estado = "A" };

            Modelo modelo1 = new Modelo() { codigo = 1, descripcion = "i10", marca = marca1, estado = "A" };
            Modelo modelo2 = new Modelo() { codigo = 2, descripcion = "Rio", marca = marca2, estado = "A" };

            Vehiculo vehiculo1= new Vehiculo() { placa = "D3R-400", vin = "LCV010787", color = color1, modelo = modelo1, anio = "2013", motor = "1.1", contacto = "Luchito Cabañas", usuario = "LCABANAS", fecha = "15/09/2013", cliente = cliente1 };
            Vehiculo vehiculo2= new Vehiculo() { placa = "D3R-401", vin = "LCN100789", color = color2, modelo = modelo2, anio = "2013", motor = "1.6", contacto = "Lorena Cermeño", usuario = "LCERMENO", fecha = "15/09/2013", cliente = cliente2 };

            List<Reserva> reservas = new List<Reserva>();
            reservas.Add(new Reserva() {codigo = 1, nroreserva = "R000001",vehiculo=vehiculo1 ,fecha = Convert.ToDateTime("16/09/2013"),numexpress =1, asesor = asesor1 , estado = "A"});
            reservas.Add(new Reserva() { codigo = 2, nroreserva = "R000002", vehiculo = vehiculo2, fecha = Convert.ToDateTime("16/09/2013"), numexpress = 2, asesor = asesor2, estado = "A" });


            return reservas;

        }


        private List<Reserva> obtenerReserva(int codigo, string nroreserva, int codigoAsesor)
        {

            List<Reserva> reservas = (List<Reserva>)Session["reservas"];
            List<Reserva> reservasResult = null;
            //foreach(Reserva reserva in reservas){

                Reserva model = reservas.Single(delegate(Reserva reserva)
                {
                    if (reserva.codigo == codigo || reserva.nroreserva == nroreserva || reserva.asesor.codigo == codigoAsesor )
                    {
                        reservasResult.Add(reserva);
                        return true;
                    }
                    else {
                        return false;
                    } 
                });

            //}

            
            return reservasResult ;
        }

        //
        // GET: /Reserva/

        public ActionResult Index(int codigo = 0, string nroreserva = "", int codigoAsesor = 0)
        {
            List<Reserva> model = null;
            if (Session["reservas"] == null)
            {
                Session["reservas"] = CrearReservas();
                model = (List<Reserva>)Session["reservas"];
            }
            else {
                model = obtenerReserva(codigo, nroreserva, codigoAsesor);
            }
            
            return View(model);
        }

        //[HttpPost]
        //public ActionResult Index(int codigo, string nroreserva, int codigoAsesor, DateTime fecha)
        //{
        //    Reserva model = obtenerReserva(codigo,nroreserva, codigoAsesor, fecha);
        //    return View(model);
        //}

        //
        // GET: /Reserva/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reserva/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Reserva/Create

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
        // GET: /Reserva/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Reserva/Edit/5

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
        // GET: /Reserva/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reserva/Delete/5

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
