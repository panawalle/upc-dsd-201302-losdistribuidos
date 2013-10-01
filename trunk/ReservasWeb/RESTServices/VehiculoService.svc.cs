using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;

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
            return dao.Crear(vehiculoACrear);
        }

        public Vehiculo ModificarAlumno(Vehiculo alumnoAModificar)
        {
            return dao.Modificar(alumnoAModificar);
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
