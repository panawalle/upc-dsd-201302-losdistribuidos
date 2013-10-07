using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SOAPServices.Dominio;
using System.ServiceModel.Web;
using System.Net;

namespace ReservasWeb.Controllers
{
    public class ReservaController : Controller
    {
        SOAPReservas.ReservaClient proxyReserva = new SOAPReservas.ReservaClient();
        SOAPAsesor.AsesorClient proxyAsesor = new SOAPAsesor.AsesorClient();
        SOAPVehiculo.VehiculoClient proxyVehiculo = new SOAPVehiculo.VehiculoClient();
        SOAPColor.ColorClient proxyColor = new SOAPColor.ColorClient();
        SOAPModelo.ModeloClient proxyModelo = new SOAPModelo.ModeloClient();
        SOAPMarca.MarcaClient proxyMarca = new SOAPMarca.MarcaClient();
        SOAPClientes.ClienteServiceClient proxyCliente = new SOAPClientes.ClienteServiceClient();

        private List<Models.Reserva> ListarReservas(int codigo, string nroreserva, string placa)
        {

            List<Reserva> objListReservas = new List<Reserva>();
            objListReservas = proxyReserva.fnListarReserva(codigo, nroreserva, placa).ToList();

            List<Models.Reserva> listReservas = new List<Models.Reserva>();

            foreach (Reserva item in objListReservas)
            {
                //Asesor
                Asesor objAsesor = new Asesor();
                objAsesor = proxyAsesor.fnObtenerAsesor(item.numCodigoAsesor);

                Models.Asesor objAsesorModel = new Models.Asesor();
                objAsesorModel.codigo = objAsesor.numCodigoAsesor;
                objAsesorModel.nombre = objAsesor.nombre;

                //Vehiculo
                Vehiculo objVehiculo = new Vehiculo();
                objVehiculo = proxyVehiculo.fnObtenerVehiculo(item.placa);

                //Vehiculo - Color
                Color objColor = new Color();
                objColor = proxyColor.fnObtenerColor(objVehiculo.codColor);

                Models.Color objColorModel = new Models.Color();
                objColorModel.codigo = objColor.codColor;
                objColorModel.descripcion = objColor.descripcion;
                objColorModel.estado = objColor.estado;

                // Vehiculo - Modelo
                Modelo objModelo = new Modelo();
                objModelo = proxyModelo.fnObtenerModelo(objVehiculo.codModelo);

                //Modelo - Marca
                Marca objMarca = new Marca();
                objMarca = proxyMarca.fnObtenerMarca(objModelo.codMarca);

                Models.Marca objMarcaModel = new Models.Marca();
                objMarcaModel.codigo = objMarca.codMarca;
                objMarcaModel.descripcion = objMarca.descripcion;
                objMarcaModel.estado = objMarca.estado;

                Models.Modelo objModeloModel = new Models.Modelo();
                objModeloModel.codigo = objModelo.codModelo;
                objModeloModel.marca = objMarcaModel;
                objModeloModel.descripcion = objModelo.descripcion;
                objModeloModel.estado = objModelo.estado;

                //Vehiculo - Cliente
                Cliente objCliente = new Cliente();
                objCliente = proxyCliente.ObtenerCliente(objVehiculo.codCliente);

                Models.Cliente objClienteModel = new Models.Cliente();
                objClienteModel.codigocliente = objCliente.codigocliente;
                objClienteModel.nombrecliente = objCliente.nombrecliente;
                objClienteModel.apellidopaterno = objCliente.apellidopaterno;
                objClienteModel.apellidomaterno = objCliente.apellidomaterno;

                Models.Vehiculo objVehiculoModel = new Models.Vehiculo();
                objVehiculoModel.placa = objVehiculo.placa;
                objVehiculoModel.color = objColorModel;
                objVehiculoModel.modelo = objModeloModel;
                objVehiculoModel.vin = objVehiculo.vin;
                objVehiculoModel.anio = objVehiculo.anio;
                objVehiculoModel.motor = objVehiculo.motor;
                objVehiculoModel.contacto = objVehiculo.contacto;
                objVehiculoModel.usuario = objVehiculo.usuario;
                objVehiculoModel.fecha = objVehiculo.fecha;
                objVehiculoModel.cliente = objClienteModel;


                Models.Reserva item2 = new Models.Reserva();
                item2.codigo = item.codReserva;
                item2.nroreserva = item.nroReserva;
                item2.vehiculo = objVehiculoModel;
                item2.fecha = item.fecha;
                item2.numexpress = item.numExpress;
                item2.asesor = objAsesorModel;
                item2.estado = item.estado;

                listReservas.Add(item2);
            }

            return listReservas;

        }

        public ActionResult Index(string codigo, string nroreserva, string placa)
        {
            try
            {
                Session["reserva"] = null;
                List<Models.Reserva> model = null;

                if (codigo == null || codigo.Equals(""))
                {
                    codigo = "0";
                }
                if (nroreserva == null || nroreserva.Equals(""))
                {
                    nroreserva = "0";
                }
                if (placa == null || placa.Equals(""))
                {
                    placa = "0";
                }

                Session["reservas"] = ListarReservas(Convert.ToInt32(codigo), nroreserva, placa);
                model = (List<Models.Reserva>)Session["reservas"];

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
                return View();
            }

        }

        public ActionResult Details(int codigo)
        {
            SOAPReservas.ReservaClient proxy = new SOAPReservas.ReservaClient();
            Reserva objReserva = new Reserva();
            objReserva = proxy.fnObtenerReserva(Convert.ToInt16(codigo));

            if (objReserva != null)
            {

            }

            return View();
        }

        public ActionResult Create()
        {   //string nroreserva, string fecha, int numexpress, string hora, int codAsesor, string placa
            try
            {
                FillDropDownList();
                Models.Reserva model = null;
                model = (Models.Reserva)Session["reserva"];

                if (model == null)
                {
                    //Traer horario de la semana de la fecha actual
                    //Models.Reserva model = new Models.Reserva();
                    model = consultarHorario(DateTime.Now.Date);
                    model.fecha = DateTime.Now.Date;
                    Session["reserva"] = model;
                }

                return View(model);
            }
            catch (Exception )
            {
                return View();
            }

        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Models.Reserva model = (Models.Reserva)Session["reserva"];
            try
            {
                Reserva objReservaResult = new Reserva();

                SOAPReservas.ReservaClient proxyReserva = new SOAPReservas.ReservaClient();

                Reserva objReserva = new Reserva();

                objReserva.nroReserva = (string)collection["nroReserva"];
                objReserva.placa = (string)collection["vehiculo.placa"];
                objReserva.fecha = Convert.ToDateTime(collection["fecha"]);
                objReserva.numExpress = Convert.ToInt32(collection["numExpress"]);
                objReserva.numCodigoAsesor = Convert.ToInt32(collection["asesor.codigo"]);
                objReserva.hora = (string)collection["ddlHorarios"];

                List<ReservaDetalle> objListReservaDetalle = new List<ReservaDetalle>();
                if (model.reservaDetalle != null)
                {
                    foreach (Models.ReservaDetalle obj in model.reservaDetalle)
                    {
                        ReservaDetalle objReservaDetalle = new ReservaDetalle();
                        objReservaDetalle.codOper = obj.servicio.codOper;
                        objReservaDetalle.codOperSer = obj.servicio.codOperSer;
                        objReservaDetalle.estado = obj.estado;
                        objListReservaDetalle.Add(objReservaDetalle);
                    }

                }
                objReserva.reservaDetalle = objListReservaDetalle;

                model.nroreserva = objReserva.nroReserva;
                model.fecha = objReserva.fecha;
                Models.Vehiculo objVehiculoModel = new Models.Vehiculo();
                objVehiculoModel.placa = objReserva.placa;
                model.vehiculo = objVehiculoModel;
                model.numexpress = objReserva.numExpress;
                Models.Asesor objAsesoModel = new Models.Asesor();
                objAsesoModel.codigo = objReserva.numCodigoAsesor;
                model.asesor = objAsesoModel;
                model.hora = objReserva.hora;

                objReservaResult = proxyReserva.fnGuardarReserva(objReserva);
                //model.blnResultado = objReservaResult.blnResultado;
                //model.strMensaje = objReservaResult.strMensaje;

                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                model = consultarHorario(model.fecha);
                model.blnResultado = false;
                model.strMensaje = e.Message;
                FillDropDownList();
                return View(model);
            }
            finally
            {
                Session["reserva"] = model;
            }
        }

        private Models.Reserva consultarHorario(DateTime fecha)
        {

            SOAPHorario.HorarioClient proxyHorario = new SOAPHorario.HorarioClient();
            Horario objHorario = new Horario();
            objHorario = proxyHorario.fnObtenerHorario(fecha);

            Models.Reserva model = (Models.Reserva)Session["reserva"];


            Models.Horario modelHorario = new Models.Horario();
            modelHorario.horario = objHorario.header;
            modelHorario.dia1 = objHorario.dia1;
            modelHorario.dia2 = objHorario.dia2;
            modelHorario.dia3 = objHorario.dia3;
            modelHorario.dia4 = objHorario.dia4;
            modelHorario.dia5 = objHorario.dia5;
            modelHorario.dia6 = objHorario.dia6;
            modelHorario.blnResultado = objHorario.blnResultado;
            modelHorario.strMensaje = objHorario.strMensaje;

            List<Models.HorarioBody> objListHorarioBody = new List<Models.HorarioBody>();
            //HorarioBody
            foreach (HorarioBody dr in objHorario.horarioBody)
            {
                Models.HorarioBody objHorarioBody = new Models.HorarioBody();

                objHorarioBody.horario = (string)dr.header;
                objHorarioBody.dia1 = (string)dr.dia1;
                objHorarioBody.dia2 = (string)dr.dia2;
                objHorarioBody.dia3 = (string)dr.dia3;
                objHorarioBody.dia4 = (string)dr.dia4;
                objHorarioBody.dia5 = (string)dr.dia5;
                objHorarioBody.dia6 = (string)dr.dia6;

                objListHorarioBody.Add(objHorarioBody);

            }
            modelHorario.horarioBody = objListHorarioBody;

            if (model == null)
            {
                model = new Models.Reserva();
                model.blnResultado = modelHorario.blnResultado;
                model.strMensaje = modelHorario.strMensaje;
            }

            model.horario = modelHorario;

            return model;

        }

        public ActionResult consultar(string fecha)
        {

            try
            {
                if (fecha != null && fecha != "")
                {
                    Models.Reserva model = null;
                    model = consultarHorario(Convert.ToDateTime(fecha));
                    model.fecha = Convert.ToDateTime(fecha);
                    Session["reserva"] = model;

                    return RedirectToAction("Create");
                }
                else
                {
                    return RedirectToAction("Create");
                }

            }
            catch (Exception e)
            {
                if (e.Message == "Bad Request")
                {
                    ModelState.AddModelError(String.Empty, "Error: Hay datos vacios o nulos.");

                }
                if (e.Message == "Not Found")
                {
                    ModelState.AddModelError(String.Empty, "Error: Reserva no encontrada");
                    //ViewData["Message"] = "Error: Hay datos vacios o nulos.";
                }
                return View();
            }
            //return View(model);
            //return RedirectToAction("Create");

        }

        public ActionResult agregarServicio(string codOperSer)
        {
            //Recupero sesion de reserva y seteo el detalle
            Models.Reserva model = (Models.Reserva)Session["reserva"];

            try
            {
                if (codOperSer != null && codOperSer != "")
                {
                    SOAPServicio.ServicioClient proxy = new SOAPServicio.ServicioClient();

                    Servicio objServicio = new Servicio();
                    objServicio = proxy.fnObtenerServicio("1X", codOperSer);

                    if (objServicio.codOper != null)
                    {
                        Models.Servicio modelServicio = new Models.Servicio();
                        modelServicio.codOper = objServicio.codOper;
                        modelServicio.codOperSer = objServicio.codOperSer;
                        modelServicio.descripcion = objServicio.descripcion;
                        modelServicio.precio = objServicio.precio;

                        List<Models.ReservaDetalle> ListaReservaDetalle = new List<Models.ReservaDetalle>();
                        Models.ReservaDetalle objReservaDetalle = new Models.ReservaDetalle();

                        objReservaDetalle.servicio = modelServicio;
                        objReservaDetalle.estado = "0";

                        if (Session["detalle"] != null)
                        {
                            ListaReservaDetalle = (List<Models.ReservaDetalle>)Session["detalle"];
                            ListaReservaDetalle.Add(objReservaDetalle);
                            Session["detalle"] = ListaReservaDetalle;
                        }
                        else
                        {
                            ListaReservaDetalle.Add(objReservaDetalle);
                            Session["detalle"] = ListaReservaDetalle;
                        }

                        model.reservaDetalle = (List<Models.ReservaDetalle>)Session["detalle"];
                    }

                }

            }
            catch (Exception e)
            {
                model = consultarHorario(model.fecha);
                model.blnResultado = false;
                model.strMensaje = e.Message;
                FillDropDownList();
            }
            finally {
                Session["reserva"] = model;
            }

            return RedirectToAction("Create", "Reserva");
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

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


        public ActionResult Delete(int id)
        {
            return View();
        }


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

        private void FillDropDownList()
        {
            //int? CountryId = 0
            SOAPHorario.HorarioClient proxyHorario = new SOAPHorario.HorarioClient();
            //TestDataContext db = new TestDataContext();
            List<Horario> objListHorarios = new List<Horario>();
            objListHorarios = proxyHorario.fnObtenerRangoHorario().ToList();

            List<SelectListItem> ddlHorarios = new List<SelectListItem>();
            ddlHorarios.Add(new SelectListItem() { Value = "0", Text = "-", Selected = false });


            foreach (Horario objHorario in objListHorarios)
                ddlHorarios.Add(
                    new SelectListItem()
                    {
                        Value = objHorario.dia1.ToString().Trim(),
                        Text = objHorario.header.ToString().Trim()//, 
                        //Selected = CountryId == country.CountryId ? true : false
                    });

            ViewData["Horarios"] = ddlHorarios;

        }
    }
}
