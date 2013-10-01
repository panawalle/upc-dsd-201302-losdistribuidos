using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReservasWeb.Models;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace ReservasWeb.Controllers
{
    public class VehiculoController : Controller
    {
        private List<Vehiculo> CrearVehiculos()
        {
            Color color1 = new Color() { codigo = 1, descripcion = "Ladrillo", estado = "A" };
            Color color2 = new Color() { codigo = 2, descripcion = "Azul", estado = "A" };

            Marca marca1 = new Marca() { codigo = 1, descripcion = "Hyundai", estado = "A" };
            Marca marca2 = new Marca() { codigo = 2, descripcion = "Kia", estado = "A" };

            Modelo modelo1 = new Modelo() { codigo = 1, descripcion = "i10", marca = marca1, estado = "A" };
            Modelo modelo2 = new Modelo() { codigo = 2, descripcion = "Rio", marca = marca2, estado = "A" };

            Departamento LimaDepa = new Departamento() { codigodepartamento = 1, nombredepartamento = "Lima" };
            Departamento CuscoDepa = new Departamento() { codigodepartamento = 2, nombredepartamento = "Cusco" };

            Provincia LimaProv = new Provincia() { codigoprovincia = 1, nombreprovincia = "Lima" };
            Provincia UrubambaProv = new Provincia() { codigoprovincia = 2, nombreprovincia = "Urubamba" };

            Distrito LimaDis = new Distrito() { codigodistrito = 1, nombredistrito = "Lima" };
            Distrito OllantaytamboDis = new Distrito() { codigodistrito = 2, nombredistrito = "Ollantaytambo" };


            Cliente cliente1 = new Cliente() { dnicliente = "44513804", nombrecliente = "Lesly", apellidopaterno = "Ormeño", correo = "lesly.varillas@gmail.com" };
            Cliente cliente2 = new Cliente() { dnicliente = "43781265", nombrecliente = "Oscar", apellidopaterno = "Santillan", correo = "oscar@gmail.com" };

            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos.Add(new Vehiculo() { placa = "D3R-400", vin = "LCV010787", color = color1, modelo = modelo1, anio = "2013", motor = "1.1", contacto = "Luchito Cabañas", usuario = "LCABANAS", fecha = "15/09/2013", cliente = cliente1 });
            vehiculos.Add(new Vehiculo() { placa = "D3R-401", vin = "LCN100789", color = color2, modelo = modelo2, anio = "2013", motor = "1.6", contacto = "Lorena Cermeño", usuario = "LCERMENO", fecha = "15/09/2013", cliente = cliente2 });


            return vehiculos;

        }

        private Vehiculo obtenerVehiculo(string placa)
        {

            List<Vehiculo> vehiculos = (List<Vehiculo>)Session["vehiculos"];
            Vehiculo model = vehiculos.Single(delegate(Vehiculo vehiculo)
            {
                if (vehiculo.placa == placa) return true;
                else return false;
            });
            return model;
        }

        //
        // GET: /Vehiculo/
        public ActionResult Index()
        {
            
            /*
            if (Session["vehiculos"] == null)
                Session["vehiculos"] = CrearVehiculos();
            List<Vehiculo> model = (List<Vehiculo>)Session["vehiculos"];
            return View(model);
            */

            HttpWebRequest req = (HttpWebRequest)WebRequest
            .Create("http://localhost:60712/VehiculoService.svc/VehiculosListar");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            //-------
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string vehiculoJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Vehiculo> list = js.Deserialize<List<Vehiculo>>(vehiculoJson);

            return View(list);
            /*SOAPClientes.ClienteServiceClient proxy = new SOAPClientes.ClienteServiceClient();
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
            */
        }

        //
        // GET: /Vehiculo/Details/5

        public ActionResult Details(string placa)
        {
            Vehiculo model = obtenerVehiculo(placa);
            return View(model);
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
            string v_placa = (string)collection["placa"];
            string v_vin = "ABCDEFGHIJ";
            string v_motor = "YYYYYYYY";
            string v_anio = "2013";
            string v_contacto = "karen Swartchz";
            string v_usuario = "Luis Suarez";
            string v_codColor = "P118";
            string v_codModelo = "SUB125";
            string v_codCliente = "15969";

            string postdata = "{\"placa\":\"" + v_placa + "\",\"vin\":\"" + v_vin + "\",\"motor\":\"" + v_motor + "\",\"anio\":\"" + v_anio + "\",\"contacto\":\"" + v_contacto + "\",\"usuario\":\"" + v_usuario + "\",\"codColor\":\"" + v_codColor + "\",\"codModelo\":\"" + v_codModelo + "\",\"codCliente\":\"" + v_codCliente + "\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:60712/VehiculoService.svc/VehiculosCrear");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;
            
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string vehiculoJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Vehiculo vehiculo = js.Deserialize<Vehiculo>(vehiculoJson);
                //Assert.AreEqual("AOM913", vehiculo.placa);
                //Assert.AreEqual(v_vin, vehiculoCreado.vin);
                //Console.WriteLine("Placa: " + v_placa);
            }
            catch (WebException e)
            {
                HttpWebResponse resError = (HttpWebResponse)e.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string errorMessage = js.Deserialize<string>(error);

                ModelState.AddModelError(String.Empty, errorMessage +"Error: Placa Incorrecta (Solo 6 digitos)");
                //Assert.AreEqual("Vehiculo Errado", errorMessage);
            }
            
            return RedirectToAction("Index");

            /*
            try
            {    
                List<Vehiculo> vehiculos = (List<Vehiculo>)Session["vehiculos"];
                vehiculos.Add(new Vehiculo()
                {
                    placa = collection["placa"],
                    vin = collection["vin"],
                    color = new Color()
                    {
                        codigo = int.Parse(collection["Color.codigo"]),
                        descripcion = collection["Color.descripcion"],
                        estado = collection["Color.estado"]
                    },
                    modelo = new Modelo()
                    {
                        codigo = int.Parse(collection["Modelo.codigo"]),
                        descripcion = collection["Modelo.descripcion"],
                        estado = collection["Modelo.estado"],
                        marca = new Marca()
                        {
                            codigo = int.Parse(collection["Marca.codigo"]),
                            descripcion = collection["Marca.descripcion"],
                            estado = collection["Marca.estado"],
                        }
                    },
                    anio = collection["anio"],
                    motor = collection["motor"],
                    contacto = collection["contacto"],
                    usuario = collection["usuario"],
                    fecha = collection["fecha"],
                    cliente = new Cliente()
                    {
                        dnicliente = collection["Cliente.dnicliente"],
                        nombrecliente = collection["Cliente.nombrecliente"]
                    }
                });
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            */
        }

        //
        // GET: /Vehiculo/Edit/5

        public ActionResult Edit(string placa)
        {
            Vehiculo model = obtenerVehiculo(placa);
            return View(model);
        }

        //
        // POST: /Vehiculo/Edit/5

        [HttpPost]
        public ActionResult Edit(string placa, FormCollection collection)
        {
            try
            {
                Vehiculo model = obtenerVehiculo(placa);
                model.color = new Color()
                {
                    codigo = int.Parse(collection["Color.codigo"]),
                    descripcion = collection["Color.descripcion"],
                    estado = collection["Color.estado"]
                };
                model.contacto = collection["Contacto"];
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Vehiculo/Delete/5

        public ActionResult Delete(string placa)
        {
            Vehiculo model = obtenerVehiculo(placa);
            return View(model);
        }

        //
        // POST: /Vehiculo/Delete/5

        [HttpPost]
        public ActionResult Delete(string placa, FormCollection collection)
        {
            try
            {
                List<Vehiculo> vehiculos = (List<Vehiculo>)Session["vehiculos"];
                vehiculos.Remove(obtenerVehiculo(placa));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
