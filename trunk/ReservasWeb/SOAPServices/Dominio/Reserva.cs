using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Reserva
    {
       [DataMember]
        public int codReserva { get; set; }
        [DataMember]
        public string nroReserva { get; set; }
        [DataMember]
        public string placa { get; set; }
        [DataMember]
        public DateTime fecha { get; set; }
        [DataMember]
        public int numExpress { get; set; }
        [DataMember]
        public int numCodigoAsesor { get; set; }
        [DataMember]
        public string estado { get; set; }
        [DataMember]
        public string hora { get; set; }
        [DataMember]
        public List<ReservaDetalle> reservaDetalle { get; set; }

        
    }
}