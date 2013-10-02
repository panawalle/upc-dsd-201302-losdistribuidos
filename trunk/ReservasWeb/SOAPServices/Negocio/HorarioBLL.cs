using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Negocio
{
    public class HorarioBLL
    {

        Persistencia.HorarioDAO objHorarioDAO = new Persistencia.HorarioDAO();

        public Dominio.Horario fnObtenerHorario(DateTime fecha)
        {
            return objHorarioDAO.fnObtenerHorario(fecha);

        }
    }
}