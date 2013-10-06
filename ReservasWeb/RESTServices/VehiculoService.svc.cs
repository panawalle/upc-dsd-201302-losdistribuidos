using System;
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
    public class VehiculoService : IVehiculo
    {
        private VehiculoDAO dao = new VehiculoDAO();

        public Vehiculo ObtenerVehiculo(string placa)
        {
            return dao.Obtener(placa);
        }

        public Vehiculo CrearVehiculo(Vehiculo vehiculoACrear)
        {
            Vehiculo beanVehiculo = null;
            beanVehiculo = dao.Obtener(vehiculoACrear.placa);

            if (beanVehiculo != null){
                throw new WebFaultException<ExcepcionError>(new ExcepcionError() { msjValidacion = "El Vehiculo con la placa " + beanVehiculo.placa + " ya existe." }, HttpStatusCode.InternalServerError);
            }else{
                beanVehiculo = new Vehiculo();
                beanVehiculo = dao.Crear(vehiculoACrear);
            }
            return beanVehiculo;
        }

        public Vehiculo ModificarVehiculo(Vehiculo vehiculoAModificar)
        {
            Vehiculo beanVehiculo = null;
            beanVehiculo = dao.Obtener(vehiculoAModificar.placa);

            if (beanVehiculo == null)
            {
                throw new WebFaultException<ExcepcionError>(new ExcepcionError() { msjValidacion = "El Vehiculo con la placa " + vehiculoAModificar.placa + " no existe." }, HttpStatusCode.InternalServerError);
            }
            else
            {
                beanVehiculo = new Vehiculo();
                beanVehiculo = dao.Modificar(vehiculoAModificar);
            }
            return beanVehiculo;
        }

        public Vehiculo EliminarAlumno(Vehiculo alumnoAEliminar)
        {
            return dao.Eliminar(alumnoAEliminar);
        }

        public List<Vehiculo> ListarVehiculos()
        {
            return dao.ListarVehiculos();
        }

    }
}
