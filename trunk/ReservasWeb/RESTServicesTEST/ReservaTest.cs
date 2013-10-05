using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using RESTServices.Dominio;

namespace RESTServicesTEST
{
    [TestClass]
    public class ReservaTest
    {
        [TestMethod]
        public void GuardarReservaTest_Ok()
        {
            string postdata = "{\"codReserva\":10," +
                "\"nroReserva\":\"XDFECT09\"," +
                "\"placa\":\"D3R400\"," +
                "\"fecha\":\"\\/Date(1379460281000-0500)\\/\"," +
                "\"numexpress\":\"1\"," +
                "\"numCodigoAsesor\":\"16\"," +
                "\"estado\":\"0\"," +
                "\"hora\":\"08:30\"," +
                    "\"reservaDetalle\":" +
                    "{\"codDetalle\":\"1\"," +
                    "\"codOper\":\"1X\"," +
                    "\"codOperSer\":\"1103H\"," +
                    "\"codReserva\":\"10\"," +
                    "\"estado\":\"0\"" +
                "}}";
            //Prueba de creación de reserva vía HTTP POST
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:60712/Reserva.svc/Reservas");
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
                string unidadJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Reserva reservaCreada = js.Deserialize<Reserva>(unidadJson);
                Assert.AreEqual("XDFECT09", reservaCreada.nroReserva);
                Assert.AreEqual(15, reservaCreada.codReserva);
                Assert.AreEqual(16, reservaCreada.numCodigoAsesor);
                Assert.AreEqual("0", reservaCreada.estado);

            }


            catch (WebException ex)
            {

                // Mostrar Error
                HttpWebResponse resError = (HttpWebResponse)ex.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                //UnidadException exception = js.Deserialize<UnidadException>(error);
                //Assert.AreEqual("El número de placa ingresado ya fue registrado para otra unidad", exception.Message);
            }

        }
    }
}
