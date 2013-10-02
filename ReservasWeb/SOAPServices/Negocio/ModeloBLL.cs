using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPService.Negocio
{
    public class ModeloBLL
    {

        Persistencia.ModeloDAO objModeloDAO = new Persistencia.ModeloDAO();

        public Dominio.Modelo fnObtenerModelo(string codModelo)
        {
            return objModeloDAO.fnObtenerModelo(codModelo);

        }

    }
}