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

            Cliente cliente1 = new Cliente() { codigocliente = 1, dnicliente = "45921955", tipo=1, nombrecliente = "Lorena", apellidopaterno  = "Cermeño", apellidomaterno ="Negrón", direccioncliente ="Direccion 1", telefono ="1234567", celular ="1212523", correo = "lcermenon@gmail.com"};
            Cliente cliente2 = new Cliente() { codigocliente = 2, dnicliente = "43781265", tipo=1, nombrecliente = "Luis", apellidopaterno = "Cabañas", apellidomaterno ="Valdiviezo", direccioncliente ="Direccion 2", telefono ="23534634", celular ="1352434", correo = "luis.cabanasv@gmail.com"};

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

        //private List<Reserva> obtenerReserva(int codigo, string nroreserva, int codigoAsesor)
        //{

        //    List<Reserva> reservas = (List<Reserva>)Session["reservas"];
        //    List<Reserva> reservasResult = null;
        //    //foreach(Reserva reserva in reservas){

        //        Reserva model = reservas.Single(delegate(Reserva reserva)
        //        {
        //            if (reserva.codigo == codigo || reserva.nroreserva == nroreserva || reserva.asesor.codigo == codigoAsesor )
        //            {
        //                reservasResult.Add(reserva);
        //                return true;
        //            }
        //            else {
        //                return false;
        //            } 
        //        });

        //    //}

            
        //    return reservasResult ;
        //}

        //
        // GET: /Reserva/

        //public ActionResult Index(int codigo = 0, string nroreserva = "", int codigoAsesor = 0)
        //{
        //    List<Reserva> model = null;
        //    if (Session["reservas"] == null)
        //    {
        //        Session["reservas"] = CrearReservas();
        //        model = (List<Reserva>)Session["reservas"];
        //    }
        //    else {
        //        model = obtenerReserva(codigo, nroreserva, codigoAsesor);
        //    }
            
        //    return View(model);
        //}

        public ActionResult Index(int codigo = 0, string nroreserva = "", int codigoAsesor = 0)
        {
            if (Session["reservas"] == null)
                Session["reservas"] = CrearReservas();
            List<Vehiculo> model = (List<Vehiculo>)Session["reservas"];
            return View(model);
        }

        public ActionResult BuscarReserva()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConsultarReservas(FormCollection form)
        {
            if ((form["codigo"] == null || form["codigo"].Trim().Equals("")) && (form["nroreserva"] == null || form["nroreserva"].Trim().Equals("")))
            {
                TempData["mensaje"] = "Ingrese código o Nro de Reserva por favor!!!";
                return View("BuscarReserva");
            }
            try
            {
                Reserva model = new Reserva();
                model = obtenerReserva(form["codigo"], form["nroreserva"]);
                return View(model);
            }
            catch (Exception e)
            {
                if (e.Message == "Bad Request")
                    ModelState.AddModelError(String.Empty, "Error: Hay datos vacios o nulos.");

                if (e.Message == "Not Found")
                    ModelState.AddModelError(String.Empty, "Error: Lector no esta registrado.");
                return View("Buscarlector");
            }
        }

        private Reserva obtenerReserva(string codigo, string nroreserva)
        {
            List<Reserva> reservas = (List<Reserva>)Session["reservas"];
            Reserva model = reservas.Single(delegate(Reserva reserva)
            {
                if (reserva.codigo == Convert.ToInt32(codigo) || reserva.nroreserva == nroreserva) return true;
                else return false;
            });
            return model;
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
