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
            string postdata = "{\"codReserva\":0," +
                "\"nroReserva\":\"XDFECT09\"," +
                "\"placa\":\"D3R400\"," +
                "\"fecha\":\"\\/Date(1379460281000-0500)\\/\"," +
                "\"numExpress\":1," +
                "\"numCodigoAsesor\":16," +
                "\"estado\":\"0\"," +
                "\"hora\":\"08:30\"," +
                    "\"reservaDetalle\":" +
                    "[{\"codDetalle\":1," +
                    "\"codOper\":\"1X\"," +
                    "\"codOperSer\":\"1103H\"," +
                    "\"codReserva\":10," +
                    "\"estado\":\"0\"" +
                "}]}";

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
                int vCodReserva = 7;
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string unidadJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Reserva reservaCreada = js.Deserialize<Reserva>(unidadJson);

                if (reservaCreada.blnResultado == true)
                {
                    Assert.AreEqual("XDFECT09", reservaCreada.nroReserva);
                    Assert.AreEqual(vCodReserva, reservaCreada.codReserva); // cada vez que se pruebe se debe aumentar uno xq es identity
                    Assert.AreEqual(16, reservaCreada.numCodigoAsesor);
                    Assert.AreEqual("0", reservaCreada.estado);

                    List<ReservaDetalle> objReservaDetalle = new List<ReservaDetalle>();
                    objReservaDetalle = reservaCreada.reservaDetalle;

                    if (objReservaDetalle != null)
                    {
                        Assert.AreEqual(1, objReservaDetalle[0].codDetalle);
                        Assert.AreEqual("1X", objReservaDetalle[0].codOper);
                        Assert.AreEqual("0", objReservaDetalle[0].estado);
                        Assert.AreEqual("1103H", objReservaDetalle[0].codOperSer);
                        Assert.AreEqual(vCodReserva, objReservaDetalle[0].codReserva);
                    }
                }
                else {
                    // Mostrar Error
                    Assert.AreEqual("El vehículo no se encuentra registrado en el Sistema.", reservaCreada .strMensaje  );
                
                }
                

            }


            catch (WebException ex)
            {

                // Mostrar Error
                HttpWebResponse resError = (HttpWebResponse)ex.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Error exception = js.Deserialize<Error>(error);
                Assert.AreEqual("El vehículo no se encuentra registrado en el Sistema", exception.strMensaje);
            }

        }

        [TestMethod]
        public void GuardarReservaTest_Vehiculo_NotOk()
        {
            string postdata = "{\"codReserva\":0," +
                "\"nroReserva\":\"XDFECT09\"," +
                "\"placa\":\"D3R400\"," +
                "\"fecha\":\"\\/Date(1379460281000-0500)\\/\"," +
                "\"numExpress\":1," +
                "\"numCodigoAsesor\":16," +
                "\"estado\":\"0\"," +
                "\"hora\":\"08:30\"," +
                    "\"reservaDetalle\":" +
                    "[{\"codDetalle\":1," +
                    "\"codOper\":\"1X\"," +
                    "\"codOperSer\":\"1103H\"," +
                    "\"codReserva\":10," +
                    "\"estado\":\"0\"" +
                "}]}";

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
                int vCodReserva = 7;
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string unidadJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Reserva reservaCreada = js.Deserialize<Reserva>(unidadJson);

                if (reservaCreada.blnResultado == true)
                {
                    Assert.AreEqual("XDFECT09", reservaCreada.nroReserva);
                    Assert.AreEqual(vCodReserva, reservaCreada.codReserva); // cada vez que se pruebe se debe aumentar uno xq es identity
                    Assert.AreEqual(16, reservaCreada.numCodigoAsesor);
                    Assert.AreEqual("0", reservaCreada.estado);

                    List<ReservaDetalle> objReservaDetalle = new List<ReservaDetalle>();
                    objReservaDetalle = reservaCreada.reservaDetalle;

                    if (objReservaDetalle != null)
                    {
                        Assert.AreEqual(1, objReservaDetalle[0].codDetalle);
                        Assert.AreEqual("1X", objReservaDetalle[0].codOper);
                        Assert.AreEqual("0", objReservaDetalle[0].estado);
                        Assert.AreEqual("1103H", objReservaDetalle[0].codOperSer);
                        Assert.AreEqual(vCodReserva, objReservaDetalle[0].codReserva);
                    }
                }
                else
                {
                    // Mostrar Error
                    Assert.AreEqual("El vehículo no se encuentra registrado en el Sistema.", reservaCreada.strMensaje);

                }


            }


            catch (WebException ex)
            {

                // Mostrar Error
                HttpWebResponse resError = (HttpWebResponse)ex.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Error exception = js.Deserialize<Error>(error);
                Assert.AreEqual("El vehículo no se encuentra registrado en el Sistema", exception.strMensaje);
            }

        }

        [TestMethod]
        public void AnularCancelarReserva_OK() {

            HttpWebRequest req = (HttpWebRequest)WebRequest
                    .Create("http://localhost:60712/Reserva.svc/ReservasA/2");
            req.Method = "PUT";
            HttpWebResponse res = null;

            try
            {

                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string reservaJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Reserva objReservaAnulado = js.Deserialize<Reserva>(reservaJson);

                Assert.AreEqual("1", objReservaAnulado.estado);

            }
            catch (WebException ex)
            {
                // Mostrar Error
                HttpWebResponse resError = (HttpWebResponse)ex.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Error exception = js.Deserialize<Error>(error);
                Assert.AreEqual("La reserva ya se encuentra Cancelada", exception.strMensaje);
            }
        }

        [TestMethod]
        public void AnularCancelarReserva_NotOk()
        {

            HttpWebRequest req = (HttpWebRequest)WebRequest
                    .Create("http://localhost:60712/Reserva.svc/ReservasA/2");
            req.Method = "PUT";
            HttpWebResponse res = null;

            try
            {

                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string reservaJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Reserva objReservaAnulado = js.Deserialize<Reserva>(reservaJson);

            }
            catch (WebException ex)
            {
                // Mostrar Error
                HttpWebResponse resError = (HttpWebResponse)ex.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Error exception = js.Deserialize<Error>(error);
                Assert.AreEqual("La reserva ya se encuentra Cancelada", exception.strMensaje);
            }
        }
    }
}
