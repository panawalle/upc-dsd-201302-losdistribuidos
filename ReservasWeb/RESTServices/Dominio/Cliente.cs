using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTServices.Dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int codigocliente { get; set; }

        [DataMember]
        public string dnicliente { get; set; }

        [DataMember]
        public int tipo { get; set; }

        [DataMember]
        public string nombrecliente { get; set; }

        [DataMember]
        public string apellidopaterno { get; set; }

        [DataMember]
        public string apellidomaterno { get; set; }

        [DataMember]
        public string direccioncliente { get; set; }

        [DataMember]
        public string telefono { get; set; }

        [DataMember]
        public string celular { get; set; }

        [DataMember]
        public string correo { get; set; }

    }
}