using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;

namespace TestProject
{
    [TestClass]
    public class TestVehiculo
    {
        /*
          AUTOR : ANTONIO QUEZADA MONZON
          HISTORIA : VEHICULO
        */

        //OBTENER DATOS VEHICULO
        [TestMethod]
        public void CRUDTest_VehiculoObtener()
        {
            string v_placa = "C5Y425"; // PONER UNA PLACA EXISTENTE 
            HttpWebRequest req = (HttpWebRequest)WebRequest
            .Create("http://localhost:60712/VehiculoService.svc/VehiculosObtener/" + v_placa);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string vehiculoJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Vehiculo vehiculo = js.Deserialize<Vehiculo>(vehiculoJson);
            Assert.AreEqual(v_placa, vehiculo.placa);
            Console.WriteLine("placa : " + vehiculo.placa);
            Console.WriteLine("Vin : " + vehiculo.vin);
            Console.WriteLine("Motor : " + vehiculo.motor);
        }

        //REGISTRAR DATOS VEHICULO
        [TestMethod]
        public void CRUDTest_VehiculoRegistrar()
        {
            string v_placa = "CGC861";
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
                Assert.AreEqual(v_placa, vehiculo.placa);
                //Assert.AreEqual(v_vin, vehiculo.vin);
                Console.WriteLine("Placa: " + vehiculo.placa);
                Console.WriteLine("Vin: " + vehiculo.vin);
                Console.WriteLine("Motor: " + vehiculo.motor);
            }
            catch (WebException e)
            {
            
                HttpWebResponse resError = (HttpWebResponse)e.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                //string errorMessage = js.Deserialize<string>(error);
                //Assert.AreEqual("Vehiculo Errado", errorMessage);
                ExcepcionError BeanError = js.Deserialize<ExcepcionError>(error);
                Console.WriteLine("Mensaje de Error: " + BeanError.msjValidacion);
                //-------
            }
        }

        //MODIFICAR DATOS VEHICULO
        [TestMethod]
        public void CRUDTest_VehiculoModificar()
        {
            string v_placa = "CGC861";
            string v_vin = "XYZ12345";
            string v_motor = "ZGTER12345";
            string v_anio = "2013";
            string v_contacto = "Ana Vertiz";
            string v_usuario = "Roberto Gomez";
            string postdata = "{\"placa\":\"" + v_placa + "\",\"vin\":\"" + v_vin + "\",\"motor\":\"" + v_motor + "\",\"anio\":\"" + v_anio + "\",\"contacto\":\"" + v_contacto + "\",\"usuario\":\"" + v_usuario + "\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:60712/VehiculoService.svc/VehiculosModificar");
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
                Assert.AreEqual(v_placa, vehiculo.placa);
                //Assert.AreEqual(v_vin, vehiculoCreado.vin);
                Console.WriteLine("Placa: " + v_placa);
                Console.WriteLine("Vin: " + vehiculo.vin);
                Console.WriteLine("Motor: " + vehiculo.motor);
            }
            catch (WebException e)
            {
                HttpWebResponse resError = (HttpWebResponse)e.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                //string errorMessage = js.Deserialize<string>(error);
                //Assert.AreEqual("Vehiculo Errado", errorMessage);
                ExcepcionError BeanError = js.Deserialize<ExcepcionError>(error);
                Console.WriteLine("Mensaje de Error: " + BeanError.msjValidacion);
            }
        }


        //--LISTAR VEHICULOS
        [TestMethod]
        public void CRUDTest_VehiculoListar()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest
            .Create("http://localhost:60712/VehiculoService.svc/VehiculosListar");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            //-------
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string vehiculoJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Vehiculo> list = js.Deserialize<List<Vehiculo>>(vehiculoJson);

            Console.WriteLine("----Listado de Vehiculo ---");
            foreach(var beanVehiculo in list){
                Console.WriteLine("Placa : " + beanVehiculo.placa + "  Vin: " + beanVehiculo.vin + "  Motor: " + beanVehiculo.motor);
            }
            Console.WriteLine("---- Fin del Listado ---");
        }

        public class ExcepcionError
        {
            public string msjValidacion { get; set; }
        }

    }
}
