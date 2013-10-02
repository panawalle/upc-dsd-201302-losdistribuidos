using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Asesor" en el código, en svc y en el archivo de configuración a la vez.
    public class Asesor : IAsesor
    {
        Negocio.AsesorBLL objAsesorBLL = new Negocio.AsesorBLL();

        public Dominio.Asesor fnObtenerAsesor(int numCodigoAsesor)
        {
            Dominio.Asesor objAsesor = new Dominio.Asesor();

            objAsesor = objAsesorBLL.fnObtenerAsesor(numCodigoAsesor);

            return objAsesor;
        }
    }
}
