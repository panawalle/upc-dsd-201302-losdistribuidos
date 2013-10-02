using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPService.Dominio
{
    [DataContract]
    public class Servicio
    {

        [DataMember]
        public string codOper { get; set; }
        [DataMember]
        public string codOperSer { get; set; }
        [DataMember]
        public string descripcion { get; set; }
        [DataMember]
        public double precio { get; set; }
    }
}