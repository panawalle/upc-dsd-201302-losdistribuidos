using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Negocio
{
    public class ServicioBLL
    {

        Persistencia.ServicioDAO objServicioDAO = new Persistencia.ServicioDAO();

        public Dominio.Servicio fnObtenerServicio(string codOper, string codOperSer)
        {
            return objServicioDAO.fnObtenerServicio(codOper, codOperSer);

        }
    }
}