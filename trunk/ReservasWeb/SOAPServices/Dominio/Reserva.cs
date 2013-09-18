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
        public int Codigo { get; set; } 
        [DataMember]
        public string NroReserva { get; set; }
        [DataMember]
        public string Placa { get; set; }
        [DataMember]
        public string Fecha { get; set; }
        [DataMember]
        public int NumExpress { get; set; }
        [DataMember]
        public int CodAsesor { get; set; }
        [DataMember]
        public int Estado { get; set; }

    }
}