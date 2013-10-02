using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Negocio
{
    public class ColorBLL
    {

        Persistencia.ColorDAO objColorDAO = new Persistencia.ColorDAO();

        public Dominio.Color fnObtenerColor(string codColor)
        {
            return objColorDAO.fnObtenerColor(codColor);

        }
    }
}