using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Asesor
    {

        [DataMember]
        public int numCodigoAsesor { get; set; }

        [DataMember]
        public string nombre { get; set; }

    }
}