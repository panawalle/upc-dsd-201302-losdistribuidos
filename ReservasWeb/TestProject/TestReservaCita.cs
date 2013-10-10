using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    /*
     AUTOR : ANTONIO QUEZADA MONZON
     HISTORIA : ANULAR RESERVA
    */
    [TestClass]
    public class TestReservaCita
    {

        //ANULAR RESERVA (CAMBIA ESTADO A = "1")
        [TestMethod]
        public void CRUDTest_ReservaCitaAnular()
        {
            string v_codReserva = "175";

            string postdata = "{\"nroreserva\":\"" + v_codReserva + "\"}";  //nroreserva
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:60712/ReservaCitaService.svc/ReservaAnular");
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
                ReservaCita reserva = js.Deserialize<ReservaCita>(vehiculoJson);
                //Assert.AreEqual(v_codReserva, reserva.nroreserva);
                Console.WriteLine("Se Actualizo la Reserva:");
                Console.WriteLine("Codigo : " + reserva.codigo);
                Console.WriteLine("Nro.Reserva: " + reserva.nroreserva);
                Console.WriteLine("Estado: " + reserva.estado );
                Console.WriteLine("Placa: " + reserva.vehiculo.placa );
            }
            catch (WebException e)
            {
                HttpWebResponse resError = (HttpWebResponse)e.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                //string errorMessage = js.Deserialize<string>(error);
                //Assert.AreEqual("Cita Error al Anular", errorMessage);
                ExcepcionError BeanError = js.Deserialize<ExcepcionError>(error);
                Console.WriteLine("Mensaje de Error: " + BeanError.msjValidacion);
            }
        }

        public class ExcepcionError
        {
            public string msjValidacion { get; set; }
        }

    }
}
