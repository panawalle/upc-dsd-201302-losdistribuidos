using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace TestProject
{
    public class Vehiculo
    {
        public string placa { get; set; }
        public string vin { get; set; }
        public string codColor { get; set; }
        public string codModelo { get; set; }
        public string anio { get; set; }
        public string motor { get; set; }
        public string contacto { get; set; }
        public string usuario { get; set; }
        public string fecha { get; set; }
        public string codCliente { get; set; }
        public string nomCliente { get; set; }
        public string descColor { get; set; }
        public string descModelo { get; set; }
        public Cliente cliente { get; set; }






        public class Cliente
        {
            public int codigocliente { get; set; }
            public string dnicliente { get; set; }
            public int tipo { get; set; }
            public string nombrecliente { get; set; }
            public string apellidopaterno { get; set; }
            public string apellidomaterno { get; set; }
            public string direccioncliente { get; set; }
            public string telefono { get; set; }
            public string celular { get; set; }
            public string correo { get; set; }
        }

    }
}