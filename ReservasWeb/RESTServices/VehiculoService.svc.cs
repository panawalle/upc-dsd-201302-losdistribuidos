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
        private ClienteDAO daoCliente = new ClienteDAO();

        public Vehiculo ObtenerVehiculo(string placa)
        {
            return dao.Obtener(placa);
        }

        public Vehiculo CrearVehiculo(Vehiculo vehiculoACrear)
        {
            Vehiculo beanVehiculo = null;
            beanVehiculo = dao.Obtener(vehiculoACrear.placa);

            //Validando placa repetida
            if (beanVehiculo != null){
                throw new WebFaultException<ExcepcionError>(new ExcepcionError() { msjValidacion = "El Vehiculo con la placa " + beanVehiculo.placa + " ya existe." }, HttpStatusCode.InternalServerError);
            }else{
                //Validacion de cliente : Debe existir el cliente
                
                Cliente beanCliente = null;
                int v_codCli = int.Parse(vehiculoACrear.codCliente);
                beanCliente = daoCliente.ObtenerXCodigo(v_codCli);

                if (beanCliente == null){
                    throw new WebFaultException<ExcepcionError>(new ExcepcionError() { msjValidacion = "El Cliente no existe." }, HttpStatusCode.InternalServerError);
                }else {
                    //----- Solo si el cliente existe y la placa no se repite => Graba
                    beanVehiculo = new Vehiculo();
                    beanVehiculo = dao.Crear(vehiculoACrear);
                }
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
