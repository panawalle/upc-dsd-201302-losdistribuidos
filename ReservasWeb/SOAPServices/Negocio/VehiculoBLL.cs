using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Negocio
{
    public class VehiculoBLL
    {

        Persistencia.VehiculoDAO objVehiculoDAO = new Persistencia.VehiculoDAO();

        public Dominio.Vehiculo fnObtenerVehiculo(string placa)
        {
            return objVehiculoDAO.fnObtenerVehiculo(placa );
        }

    }
}