using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTServices.Dominio
{
    [DataContract]
    public class ExcepcionError
    {
        [DataMember]
        public string msjValidacion { get; set; }
    }
}