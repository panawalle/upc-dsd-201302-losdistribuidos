using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPService.Dominio
{
    [DataContract]
    public class Modelo
    {
        [DataMember]
        public string codModelo { get; set; }
        [DataMember]
        public int codMarca { get; set; }
        [DataMember]
        public string descripcion { get; set; }
        [DataMember]
        public string estado { get; set; }
    }
}