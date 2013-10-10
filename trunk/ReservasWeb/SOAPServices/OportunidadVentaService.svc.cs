using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ReservasWeb.Persistencia;
using SOAPServices.Dominio;
using System.ServiceModel.Web;
using System.Net;
using System.ComponentModel.DataAnnotations;
using SOAPServices.Persistencia;

namespace SOAPServices
{
    public class OportunidadVentaService : IOportunidadVentaService
    {
        private OportunidadVentaDAO oportunidadventaDAO = null;
        private OportunidadVentaDAO OportunidadVentaDAO
        {
            get
            {
                if (oportunidadventaDAO == null)
                    oportunidadventaDAO = new OportunidadVentaDAO();
                return oportunidadventaDAO;
            }
        }

        //Listado de Oportunidades de Venta en el sistema.
        public List<OportunidadVenta> ListarOportunidadVenta()
        {
            return OportunidadVentaDAO.ListarTodos().ToList();
        }

        //Registro de Oportunidades de Venta
        public OportunidadVenta RegistrarOportunidadVenta(int codigo, string nombre, int cantidad, string precio)
        {
            try
            {
                if (OportunidadVentaDAO.Obtener(codigo) != null)
                {
                    throw new WebFaultException<Error>(new Error() { CodError = "US001", MesError = "DNI ya esta registrado." }, HttpStatusCode.NotAcceptable);
                }
                else
                {
                    OportunidadVenta entOportunidadVenta = new OportunidadVenta()
                    {
                        codServicio = codigo,
                        nombreServicio = nombre,
                        cantidadServicio = cantidad,
                        precioServicio = precio,
                      
                    };

                    return OportunidadVentaDAO.Crear(entOportunidadVenta);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //Obtener Oportunidad Venta
        public OportunidadVenta ObtenerOportunidadVenta(int codigo)
        {
            return OportunidadVentaDAO.Obtener(codigo);
        }

        //Modificar Cliente
        public OportunidadVenta ModificarOportunidadVenta(int codigo, string nombre, int cantidad, string precio)
        {
            OportunidadVenta oportunidadventaCrear = new OportunidadVenta()
            {
                codServicio = codigo,
                nombreServicio = nombre,
                cantidadServicio = cantidad,
                precioServicio = precio,
                      
            };
            return OportunidadVentaDAO.Modificar(oportunidadventaCrear);
        }

        //Eliminar Cliente
        public void EliminarOportunidadVenta(int codigo)
        {
            OportunidadVenta asesorExistente = OportunidadVentaDAO.Obtener(codigo);
            OportunidadVentaDAO.Eliminar(asesorExistente);
        }

   
    }
}
