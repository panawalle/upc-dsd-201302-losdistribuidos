using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTServices.Dominio
{
    [DataContract]
    public class ReservaCita
    {
        [DataMember]
        public int codigo { get; set; }
        [DataMember]
        public string nroreserva { get; set; }
        [DataMember]
        public Vehiculo vehiculo { get; set; }
        [DataMember]
        public DateTime fecha { get; set; }
        [DataMember]
        public int numexpress { get; set; }
        //public Asesor asesor { get; set; }
         [DataMember]
        public string estado { get; set; }
    }
}