﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject
{
    public class ReservaCita
    {
        public int codigo { get; set; }
        public string nroreserva { get; set; }
        public Vehiculo vehiculo { get; set; }
        public DateTime fecha { get; set; }
        public int numexpress { get; set; }
        //public Asesor asesor { get; set; }
        public string estado { get; set; }
    }
}
