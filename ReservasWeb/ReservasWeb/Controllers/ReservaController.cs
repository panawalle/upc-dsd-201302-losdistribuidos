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
            Asesor asesor1 = new Asesor() { codigo = 1, nombre = "Juan La Cruza" };
            Asesor asesor2 = new Asesor() { codigo = 2, nombre = "José Figueroa" };

            Cliente cliente1 = new Cliente() { codigocliente = 1, dnicliente = "45921955", tipo = 1, nombrecliente = "Lorena", apellidopaterno = "Cermeño", apellidomaterno = "Negrón", direccioncliente = "Direccion 1", telefono = "1234567", celular = "1212523", correo = "lcermenon@gmail.com" };
            Cliente cliente2 = new Cliente() { codigocliente = 2, dnicliente = "43781265", tipo = 1, nombrecliente = "Luis", apellidopaterno = "Cabañas", apellidomaterno = "Valdiviezo", direccioncliente = "Direccion 2", telefono = "23534634", celular = "1352434", correo = "luis.cabanasv@gmail.com" };
            Cliente cliente3 = new Cliente() { codigocliente = 2, dnicliente = "10070970011", tipo = 2, nombrecliente = "ROSATEL S.A", apellidopaterno = "", apellidomaterno = "", direccioncliente = "Direccion 3", telefono = "124114", celular = "", correo = "admrosatel@rosatel.com.pe" };
            Cliente cliente4 = new Cliente() { codigocliente = 2, dnicliente = "10372374012", tipo =2, nombrecliente = "GRUAS MIURA S.A.C", apellidopaterno = "", apellidomaterno = "", direccioncliente = "Direccion 4", telefono = "121412", celular = "", correo = "gruiasmiura@hotmail.com" };
            
            Color color1 = new Color() { codigo = 1, descripcion = "Ladrillo", estado = "A" };
            Color color2 = new Color() { codigo = 2, descripcion = "Azul", estado = "A" };
            Color color3 = new Color() { codigo = 3, descripcion = "Rojo", estado = "A" };
            Color color4 = new Color() { codigo = 4, descripcion = "Negro", estado = "A" };

            Marca marca1 = new Marca() { codigo = 1, descripcion = "Hyundai", estado = "A" };
            Marca marca2 = new Marca() { codigo = 2, descripcion = "Kia", estado = "A" };
            Marca marca3 = new Marca() { codigo = 3, descripcion = "Toyota", estado = "A" };
            Marca marca4 = new Marca() { codigo = 4, descripcion = "Nissan", estado = "A" };

            Modelo modelo1 = new Modelo() { codigo = 1, descripcion = "i10", marca = marca1, estado = "A" };
            Modelo modelo2 = new Modelo() { codigo = 2, descripcion = "Rio", marca = marca2, estado = "A" };
            Modelo modelo3 = new Modelo() { codigo = 3, descripcion = "Sedan", marca = marca3, estado = "A" };
            Modelo modelo4 = new Modelo() { codigo = 4, descripcion = "Sentra", marca = marca4, estado = "A" };

            Vehiculo vehiculo1 = new Vehiculo() { placa = "D3R-400", vin = "LCV010787", color = color1, modelo = modelo1, anio = "2013", motor = "1.1", contacto = "Lorena Cermeño", usuario = "LCERMENO", fecha = "15/09/2013", cliente = cliente1 };
            Vehiculo vehiculo2 = new Vehiculo() { placa = "D3R-092", vin = "LCN100789", color = color2, modelo = modelo2, anio = "2010", motor = "1.6", contacto = "Luis Cabañas", usuario = "LCABANAS", fecha = "15/09/2013", cliente = cliente2 };
            Vehiculo vehiculo3 = new Vehiculo() { placa = "ADQ-345", vin = "LCN100790", color = color3, modelo = modelo3, anio = "2000", motor = "1.5", contacto = "Diana Hugarte", usuario = "DHUGARTE", fecha = "15/09/2013", cliente = cliente3 };
            Vehiculo vehiculo4 = new Vehiculo() { placa = "LME-768", vin = "LCN100791", color = color4, modelo = modelo4, anio = "2006", motor = "1.4", contacto = "Carolina Centeno", usuario = "CCENTENO", fecha = "15/09/2013", cliente = cliente4 };
            Vehiculo vehiculo5 = new Vehiculo() { placa = "RMT-345", vin = "LCN100792", color = color4, modelo = modelo2, anio = "2012", motor = "1.6", contacto = "Jose Luis Ormeño", usuario = "JLORMENO", fecha = "15/09/2013", cliente = cliente3 };
            Vehiculo vehiculo6 = new Vehiculo() { placa = "D56-234", vin = "LCN100793", color = color4, modelo = modelo3, anio = "2011", motor = "1.6", contacto = "Dante Espinoza", usuario = "DESPINOZA", fecha = "15/09/2013", cliente = cliente4 };

            List<Reserva> reservas = new List<Reserva>();
            reservas.Add(new Reserva() { codigo = 1, nroreserva = "R000001", vehiculo = vehiculo1, fecha = Convert.ToDateTime("16/09/2013"), numexpress = 1, asesor = asesor1, estado = "P" });
            reservas.Add(new Reserva() { codigo = 2, nroreserva = "R000002", vehiculo = vehiculo2, fecha = Convert.ToDateTime("15/09/2013"), numexpress = 2, asesor = asesor2, estado = "P" });
            reservas.Add(new Reserva() { codigo = 3, nroreserva = "R000003", vehiculo = vehiculo3, fecha = Convert.ToDateTime("10/09/2013"), numexpress = 3, asesor = asesor1, estado = "P" });
            reservas.Add(new Reserva() { codigo = 4, nroreserva = "R000004", vehiculo = vehiculo4, fecha = Convert.ToDateTime("09/09/2013"), numexpress = 4, asesor = asesor2, estado = "P" });
            reservas.Add(new Reserva() { codigo = 5, nroreserva = "R000005", vehiculo = vehiculo5, fecha = Convert.ToDateTime("09/09/2013"), numexpress = 5, asesor = asesor1, estado = "P" });
            reservas.Add(new Reserva() { codigo = 6, nroreserva = "R000006", vehiculo = vehiculo6, fecha = Convert.ToDateTime("11/09/2013"), numexpress = 6, asesor = asesor2, estado = "P" });


            return reservas;

        }

        private List<Reserva> obtenerReservaxFiltros(string codigo, string nroreserva, string placa)
        {

            List<Reserva> reservas = (List<Reserva>)Session["reservas"];
            var reservasResult = new List<Reserva>();

            //Reserva model = new Reserva();
            //model = obtenerReserva(codigo, nroreserva, placa);
            //reservasResult.Add(model);
                       
            Reserva model = reservas.Single(delegate(Reserva reserva)
            {
                //if (reserva.codigo == Convert.ToInt32(codigo) || reserva.nroreserva == nroreserva || reserva.vehiculo.placa == placa)
                if ((reserva.codigo == Convert.ToInt32(codigo) || Convert.ToInt32(codigo) == 0) && (reserva.nroreserva == nroreserva || nroreserva.Equals("")) && (reserva.vehiculo.placa == placa || placa.Equals("")))
                {
                    reservasResult.Add(reserva);
                    return true;
                }
                else return false;
            });
            
            Session["reservas"] = reservasResult;
            return reservasResult;
        }


        public ActionResult Index(string codigo, string nroreserva, string placa)
        {

            //if (Session["reservas"] == null)
            //    Session["reservas"] = CrearReservas();
            //List<Reserva> model = (List<Reserva>)Session["reservas"];
            //return View(model);
            try
            {
                List<Reserva> model = null;
                if (Session["reservas"] == null)
                {
                    Session["reservas"] = CrearReservas();
                    model = (List<Reserva>)Session["reservas"];
                }
                else
                {

                    if ((codigo == null || codigo.Trim().Equals("")) && (nroreserva == null || nroreserva.Trim().Equals("")) && (placa == null || placa.Trim().Equals("")))
                    {
                        Session["reservas"] = CrearReservas();
                        model = (List<Reserva>)Session["reservas"];
                    }
                    else
                    {
                        if (codigo == null || codigo.Trim().Equals("")) {
                            codigo = "0";
                        }
                        model = obtenerReservaxFiltros(codigo, nroreserva, placa);
                    }
                }

                if (model == null)
                {
                    return View();
                }
                else
                {
                    return View(model);
                }
                //return View(model);
            }
            catch (Exception e)
            {
                if (e.Message == "Bad Request") {
                    ModelState.AddModelError(String.Empty, "Error: Hay datos vacios o nulos.");
                    
                }
                if (e.Message == "Not Found") {
                    ModelState.AddModelError(String.Empty, "Error: Reserva no encontrada");
                    //ViewData["Message"] = "Error: Hay datos vacios o nulos.";
                }
                return View();
            }
            

        }

        //private Reserva obtenerReserva(string codigo, string nroreserva, string placa)
        //{
        //    List<Reserva> reservas = (List<Reserva>)Session["reservas"];
        //    Reserva model = reservas.Single(delegate(Reserva reserva)
        //    {
        //        if ((reserva.codigo == Convert.ToInt32(codigo) || Convert.ToInt32(codigo) == 0) && (reserva.nroreserva == nroreserva || nroreserva.Equals("")) && (reserva.vehiculo.placa == placa || placa.Equals(""))) return true;
        //        else return false;
        //    });
        //    return model;
        //}

        //public ActionResult ConsultarReservas(string codigo, string nroreserva)
        //{
        //    //if ((form["codigo"] == null || form["codigo"].Trim().Equals("")) && (form["nroreserva"] == null || form["nroreserva"].Trim().Equals("")))
        //    if ((codigo == null || codigo.Trim().Equals("")) && (nroreserva == null || nroreserva.Trim().Equals("")))
        //    {
        //        TempData["mensaje"] = "Ingrese código o Nro de Reserva por favor!!!";
        //        return View();
        //    }
        //    try
        //    {
        //        List<Reserva> model = null;
        //        model = obtenerListaReserva(codigo, nroreserva);
        //        return View();
        //    }
        //    catch (Exception e)
        //    {
        //        if (e.Message == "Bad Request")
        //            ModelState.AddModelError(String.Empty, "Error: Hay datos vacios o nulos.");

        //        if (e.Message == "Not Found")
        //            ModelState.AddModelError(String.Empty, "Error: Lector no esta registrado.");
        //        return View("Buscarlector");
        //    }
        //}

    
        //
        // GET: /Reserva/Details/5

        private Reserva obtenerReserva(int codigo)
        {

            List<Reserva> reservas = (List<Reserva>)Session["reservas"];
            Reserva model = reservas.Single(delegate(Reserva reserva)
            {
                if (reserva.codigo == codigo) return true;
                else return false;
            });
            return model;
        }

        public ActionResult Details(int codigo)
        {
            Reserva model = obtenerReserva(codigo);
            return View(model);
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
