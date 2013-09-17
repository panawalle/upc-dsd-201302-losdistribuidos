using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPServices
{
   
    [ServiceContract]
    public interface IReserva
    {
        [OperationContract]
        void EliminarReserva(int codigo);
        [OperationContract]
        List<Reserva> ListarReservas();
    }
}
