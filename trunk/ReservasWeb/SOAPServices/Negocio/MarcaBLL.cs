using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Negocio
{
    public class MarcaBLL
    {

        Persistencia.MarcaDAO objMarcaDAO = new Persistencia.MarcaDAO();

        public Dominio.Marca fnObtenerMarca(int codMarca)
        {
            return objMarcaDAO.fnObtenerMarca(codMarca);

        }

    }
}