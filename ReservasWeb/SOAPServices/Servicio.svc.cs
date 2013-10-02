using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Servicio" en el código, en svc y en el archivo de configuración a la vez.
    public class Servicio : IServicio
    {
        Negocio.ServicioBLL objServicioBLL = new Negocio.ServicioBLL();

        public Dominio.Servicio fnObtenerServicio(string codOper, string codOperSer)
        {
            Dominio.Servicio objServicio = new Dominio.Servicio();

            objServicio  = objServicioBLL.fnObtenerServicio(codOper, codOperSer );

            return objServicio;

        }
    }
}
