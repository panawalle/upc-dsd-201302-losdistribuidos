using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Horario" en el código, en svc y en el archivo de configuración a la vez.
    public class Horario : IHorario
    {
        Negocio.HorarioBLL objHorarioBLL = new Negocio.HorarioBLL();

        public Dominio.Horario fnObtenerHorario(DateTime fecha)
        {
            Dominio.Horario objHorario = new Dominio.Horario ();

            objHorario = objHorarioBLL.fnObtenerHorario(fecha);

            return objHorario;
        }


        public List<Dominio.Horario> fnObtenerRangoHorario()
        {
            List<Dominio.Horario> objListHorario = new List<Dominio.Horario>();

            objListHorario = objHorarioBLL.fnObtenerRangoHorario();

            return objListHorario;
        }
    }
}
