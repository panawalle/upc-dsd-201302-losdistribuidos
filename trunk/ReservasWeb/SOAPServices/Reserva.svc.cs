using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Net;
using SOAPServices.Dominio;
using System.ComponentModel.DataAnnotations;


namespace SOAPServices
{
    public class Reserva : IReserva
    {

        Negocio.ReservaBLL objReservaBLL = new Negocio.ReservaBLL();
        SOAPVehiculo.VehiculoClient proxyVehiculo = new SOAPVehiculo.VehiculoClient();
        SOAPAsesor.AsesorClient proxyAsesor = new SOAPAsesor.AsesorClient();


        public Dominio.Reserva fnObtenerReserva(int codReserva)
        {
            Dominio.Reserva objReserva = new Dominio.Reserva();
            try
            {
                objReserva = objReservaBLL.fnObtenerReserva(codReserva);
                            

            }
            catch (Exception)
            {
                
                throw;
            }
           

            return objReserva;
        }

        public Dominio.Reserva fnGuardarReserva(Dominio.Reserva objReserva)
        {
            Dominio.Reserva objReservaRegistrado = new Dominio.Reserva();

            //Obtener vehículo, este servicio valida la existencia del vehículo
            SOAPVehiculo.Vehiculo objVehiculo = new SOAPVehiculo.Vehiculo();
            objVehiculo = proxyVehiculo.fnObtenerVehiculo(objReserva.placa);
            
            //Obtener asesor, este servicio valida la existencia del asesor
            SOAPAsesor.Asesor objAsesor = new SOAPAsesor.Asesor();
            objAsesor = proxyAsesor.fnObtenerAsesor(objReserva.numCodigoAsesor);

            if (objReserva.hora == "0")
            {
                throw new FaultException<Dominio.Error>(new Dominio.Error
                {
                    MesError = "Seleccione un horario para la reserva."
                }, new FaultReason("Seleccione un horario para la reserva"));
            }  


            //Validar que se haya seleccionado al menos un servicio para el detalle de la reserva
            if (objReserva.reservaDetalle == null || objReserva.reservaDetalle.Count <= 0)
            {
                throw new FaultException<Dominio.Error>(new Dominio.Error
                {
                    MesError = "Por favor seleccione al menos un servicio."
                }, new FaultReason("Por favor seleccione al menos un servicio."));
            }  

            //Guardar reserva
            objReservaRegistrado = objReservaBLL.fnGuardarReserva(objReserva);
            
            //Si hubo algún error en el registrar enviar exception
            if(objReservaRegistrado.blnResultado==false){
                throw new FaultException<Dominio.Error>(new Dominio.Error
                {
                    MesError  = objReservaRegistrado.strMensaje
                }, new FaultReason(objReservaRegistrado.strMensaje));

            }    

            return objReservaRegistrado;

        }

        public List<Dominio.Reserva> fnListarReserva(int codReserva, string nroReserva, string placa, int codestado)
        {
            List<Dominio.Reserva> objListReserva = new List<Dominio.Reserva>();

            objListReserva = objReservaBLL.fnListarReserva(codReserva, nroReserva, placa, codestado);

            return objListReserva;
        }

    }
}
