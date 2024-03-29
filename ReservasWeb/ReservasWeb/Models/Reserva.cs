﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ReservasWeb.Models
{
    public class Reserva
    {

        public int codigo { get; set; }
        public string nroreserva { get; set; }
        public Vehiculo vehiculo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fecha { get; set; }
        
        public int numexpress { get; set; }
        public Asesor asesor { get; set; }
        public string estado { get; set; }
        public string hora { get; set; }
        public Horario horario { get; set; }
        public List<ReservaDetalle> reservaDetalle { get; set; }
        public Boolean blnResultado { get; set; }        
        public string strMensaje { get; set; }
    }
}