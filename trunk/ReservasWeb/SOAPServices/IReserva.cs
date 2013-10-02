using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace SOAPServices
{
    [ServiceContract]
    public interface IReserva
    {

        [OperationContract]
        Dominio.Reserva fnObtenerReserva(int codReserva);

        [OperationContract]
        Dominio.Reserva fnGuardarReserva(Dominio.Reserva objReserva);

        [OperationContract]
        List<Dominio.Reserva> fnListarReserva(int codReserva, string nroReserva, string placa);
    }


}
