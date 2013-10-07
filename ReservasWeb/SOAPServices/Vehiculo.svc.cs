using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Vehiculo" en el código, en svc y en el archivo de configuración a la vez.
    public class Vehiculo : IVehiculo
    {
        Negocio.VehiculoBLL objVehiculoBLL = new Negocio.VehiculoBLL();

        public Dominio.Vehiculo fnObtenerVehiculo(string placa)
        {
            Dominio.Vehiculo objVehiculo = new Dominio.Vehiculo();

            objVehiculo = objVehiculoBLL.fnObtenerVehiculo(placa);

            if (objVehiculo.blnResultado == false)
            {
                throw new FaultException<Dominio.Error>(new Dominio.Error
                {
                    MesError = objVehiculo.strMensaje
                }, new FaultReason(objVehiculo.strMensaje));

            } 

            return objVehiculo;
        }
    }
}
