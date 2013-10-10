using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;
using System.ComponentModel.DataAnnotations;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IOportunidadVentaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IOportunidadVentaService
    {
        [OperationContract]
        OportunidadVenta RegistrarOportunidadVenta(int codServicio, string nombreServicio, int cantidadServicio, string precioServicio);

        [OperationContract]
        OportunidadVenta ObtenerOportunidadVenta(int codServicio);

        [OperationContract]
        OportunidadVenta ModificarOportunidadVenta(int codServicio, string nombreServicio, int cantidadServicio, string precioServicio);

        [OperationContract]
        void EliminarOportunidadVenta(int codServicio);

        [OperationContract]
        List<OportunidadVenta> ListarOportunidadVenta();

        //[FaultContract(typeof(ValidationException))]
        //[OperationContract]
        //int ValidarOportunidadVentaExistemte(int id);
    }
}
