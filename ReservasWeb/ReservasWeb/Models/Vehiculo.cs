﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservasWeb.Models
{
    public class Vehiculo
    {
        public string placa { get; set; }
        public string vin { get; set; }
        public Color color { get; set; }
        public Modelo modelo { get; set; }
        public string anio { get; set; }
        public string motor { get; set; }
        public string contacto { get; set; }
        public string usuario { get; set; }
        public DateTime fecha { get; set; }
        public Cliente cliente { get; set; }
        public string descColor { get; set; }
        public string descModelo { get; set; }
        public string nomCliente { get; set; }

    }
}