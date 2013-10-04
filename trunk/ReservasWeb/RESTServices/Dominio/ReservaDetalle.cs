using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTServices.Dominio
{
    [DataContract]
    public class ReservaDetalle
    {
        [DataMember]
        public int codDetalle { get; set; }
        [DataMember]
        public int codReserva { get; set; }
        [DataMember]
        public string codOper { get; set; }
        [DataMember]
        public string codOperSer { get; set; }
        [DataMember]
        public string estado { get; set; }
    }
}