﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Horario
    {

        [DataMember]
        public string header { get; set; }

        [DataMember]
        public string dia1 { get; set; }

        [DataMember]
        public string dia2 { get; set; }

        [DataMember]
        public string dia3 { get; set; }

        [DataMember]
        public string dia4 { get; set; }

        [DataMember]
        public string dia5 { get; set; }

        [DataMember]
        public string dia6 { get; set; }

        [DataMember]
        public List<HorarioBody> horarioBody { get; set; }
        
        [DataMember]
        public Boolean blnResultado { get; set; }
        [DataMember]
        public string strMensaje { get; set; }

    }
}