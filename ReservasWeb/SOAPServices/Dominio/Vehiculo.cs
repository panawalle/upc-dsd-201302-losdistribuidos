using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Vehiculo
    {

        [DataMember]
        public string placa { get; set; }

        [DataMember]
        public string vin { get; set; }

        [DataMember]
        public string codColor { get; set; }

        [DataMember]
        public string codModelo { get; set; }

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

        [DataMember]
        public Boolean blnResultado { get; set; }
        [DataMember]
        public string strMensaje { get; set; }

    }
}