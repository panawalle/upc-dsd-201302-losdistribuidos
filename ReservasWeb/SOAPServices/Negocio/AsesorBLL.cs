using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPService.Negocio
{
    public class AsesorBLL
    {
        Persistencia.AsesorDAO objAsesorDAO = new Persistencia.AsesorDAO();

        public Dominio.Asesor fnObtenerAsesor(int numCodigoAsesor)
        {
            return objAsesorDAO.fnObtenerAsesor(numCodigoAsesor);
        }

    }
}