using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPService.Dominio
{
    [DataContract]
    public class Vehiculo
    {

        [DataMember]
        public string placa { get; set; }

        [DataMember]
        public string vin { get; set; }

        [DataMember]
        public string codcolor { get; set; }

        [DataMember]
        public string codmodelo { get; set; }

        [DataMember]
        public string anio { get; set; }

        [DataMember]
        public string motor { get; set; }

        [DataMember]
        public string contacto { get; set; }

        [DataMember]
        public string usuario { get; set; }

        [DataMember]
        public DateTime fecha { get; set; }

        [DataMember]
        public int codCliente { get; set; }

    }
}