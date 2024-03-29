﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;
using System.ServiceModel.Web;
using System.Net;

namespace RESTServices
{
    public class Reserva : IReserva
    {
        private ReservaDAO objReservaDAO = new ReservaDAO();

        public Dominio.Reserva fnObtenerReserva(string codReserva)
        {
            Dominio.Reserva objReservaResult = new Dominio.Reserva();
            int intCodReserva;

            try
            {
                intCodReserva = Convert.ToInt32(codReserva);
                objReservaResult = objReservaDAO.fnObtenerReserva(intCodReserva);
            }
            catch (Exception)
            {

                throw new WebFaultException<Error>(new Error() { strMensaje = objReservaResult.strMensaje }, System.Net.HttpStatusCode.BadRequest);
            }

            return objReservaResult;
        }

        public Dominio.Reserva fnGuardarReserva(Dominio.Reserva objReserva)
        {
            Dominio.Reserva objReservaResult = new Dominio.Reserva();
            try
            {
                objReservaResult = objReservaDAO.fnGuardarReserva(objReserva);

                //if (objReservaResult.blnResultado == false)
               
                //{
                //    throw new WebFaultException<Error>(
                //    new Error()
                //    {
                //        strMensaje  = objReservaResult.strMensaje
                //    },
                //        HttpStatusCode.BadRequest);

                //}

            }
            catch (Exception)
            {
                throw new WebFaultException<Error>(new Error() { strMensaje = objReservaResult.strMensaje }, System.Net.HttpStatusCode.BadRequest);
            }
            return objReservaResult;
        }

        public List<Dominio.Reserva> fnListarReserva(string codReserva="0", string nroReserva="0", string placa="0", string codestado = "-1")
        {
            List<Dominio.Reserva> objReservaResult = new List<Dominio.Reserva>();
            int intCodReserva = Convert.ToInt32(codReserva);
            int intCodEstado = Convert.ToInt32(codestado);

            objReservaResult = objReservaDAO.fnListarReserva(intCodReserva, nroReserva, placa, intCodEstado);
            
            return objReservaResult;
        }

        public Dominio.Reserva AnularReserva(string codReserva)
        {
            Dominio.Reserva objReservaResult = new Dominio.Reserva();
            try
            {
                int intCodReserva = Convert.ToInt32(codReserva);
                objReservaResult = objReservaDAO.fnAnularReserva(intCodReserva);

                if (objReservaResult.blnResultado == false)
                {
                    throw new WebFaultException<Error>(
                    new Error()
                    {
                        strMensaje = objReservaResult.strMensaje
                    },
                        HttpStatusCode.BadRequest);
                }
            }
            catch (Exception)
            {
                throw new WebFaultException<Error>(new Error() { strMensaje = objReservaResult.strMensaje }, System.Net.HttpStatusCode.BadRequest);
            }
            return objReservaResult;            
        }
    }
}
