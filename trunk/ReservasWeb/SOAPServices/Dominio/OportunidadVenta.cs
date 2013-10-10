using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace SOAPServices.Dominio
{
    public class OportunidadVenta
    {
        [DataMember]
        public int codServicio { get; set; }

        [DataMember]
        public string nombreServicio { get; set; }

        [DataMember]
        public int cantidadServicio { get; set; }

        [DataMember]
        public string precioServicio { get; set; }

    }
}