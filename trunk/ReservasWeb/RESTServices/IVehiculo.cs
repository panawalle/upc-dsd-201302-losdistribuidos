using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using RESTServices.Dominio;

namespace RESTServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVehiculos" in both code and config file together.
    [ServiceContract]
    public interface IVehiculo
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "VehiculosObtener/{placa}", ResponseFormat = WebMessageFormat.Json)]
        Vehiculo ObtenerVehiculo(string placa);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "VehiculosCrear", ResponseFormat = WebMessageFormat.Json)]
        Vehiculo CrearVehiculo(Vehiculo vehiculoACrear);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "VehiculosModificar", ResponseFormat = WebMessageFormat.Json)]
        Vehiculo ModificarAlumno(Vehiculo alumnoAModificar);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "VehiculosListar", ResponseFormat = WebMessageFormat.Json)]
        List<Vehiculo> ListarVehiculos();

        /*
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AlumnosEliminar", ResponseFormat = WebMessageFormat.Json)]
        Alumno EliminarAlumno(Alumno alumnoAEliminar);
        */
    }
}
